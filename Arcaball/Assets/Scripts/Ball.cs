/// <summary>
/// Ball.cs
/// Date: 26.02.2014
/// Author: Michael Boyko
/// </summary>
using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {
	
	public float yStartPos = -4f;
	public float incSpeed = 0.1f;
	public float minSpeed = 15f;
	public float maxSpeed = 20f;
	public float currentSpeed = 0;
	private Transform _t;

	void Awake() {
		_t = transform;
	}
	
	// Use this for initialization
	void Start () {
		ResetBall();
	}
	
	// Update is called once per frame
	void Update () {
		if ( _t.position.y < -4.5) 
			MissedBall();
	} 
	
	void FixedUpdate() {
			currentSpeed = Vector3.Magnitude( rigidbody.velocity );
		
		if ( currentSpeed > maxSpeed )
			rigidbody.velocity /= currentSpeed / maxSpeed;
		if ( ( currentSpeed < minSpeed ) && ( currentSpeed > 0 ) )
			rigidbody.velocity /= currentSpeed / minSpeed;
	}
	
	void OnCollisionEnter ( Collision collision ) {
		rigidbody.velocity += rigidbody.velocity * incSpeed;
	}
	
	private void MissedBall() {
		if ( Lives.currentLives-- == 1)
			GameOver();
		else {
			Lives.currentLives = Lives.currentLives--;
			ResetBall();
		}
			
	}
	
	private void ResetBall() {
		_t.position = new Vector3( Random.Range( -5.6f, 5.6f ), 0, Player.zPosition );
		_t.LookAt( GameObject.FindGameObjectWithTag( "Player" ).transform.position );
		
		rigidbody.AddRelativeForce( new Vector3( 0, 0, minSpeed ) );
		
		/*	if ( Input.GetKey( KeyCode.Space ) )
			FixedUpdate();
		else {
			 _t.position = _t.position = new Vector3( Player.PositionX() + Input.GetAxis( "Horizontal" ) * Player.speed * Time.deltaTime, yStartPos, 0);;
		}  */
	}
	
	private void GameOver() { 
		_t.position = Vector3.zero;
		_t.renderer.enabled = false;
		rigidbody.velocity = Vector3.zero;
	}
}
