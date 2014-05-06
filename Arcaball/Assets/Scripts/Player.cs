/// <summary>
/// Player.cs
/// Date: 26.02.2014
/// Author: Michael Boyko
/// 
/// Get the player input
/// move the paddle accordigly along the x axis
/// make sure the paddle is 0 on the z axis
/// create side boundries the player can not move by
/// lock moves on y axis
/// </summary>
using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
	
	public static float zPosition = 0;
	public float yPosition = -4.3f;
	public float xBoundry = 5.96f;
	public static float speed = 15f;
	private static Transform _t;

	void Awake() {
		_t = transform;
	}

	// Use this for initialization
	void Start () {
		//set position for start
		_t.position = new Vector3( 0, yPosition, zPosition );
	}
	
	// Update is called once per frame
	void Update () {
		//get player input
		if ( Input.GetAxis( "Horizontal" ) != 0) {
			//move paddle according to input along the x axis
			_t.position = new Vector3( _t.position.x + Input.GetAxis( "Horizontal" ) * speed * Time.deltaTime, yPosition, zPosition );
		}
		
		//check boundries
		if ( _t.position.x < -xBoundry )
			_t.position = new Vector3( -xBoundry, yPosition, zPosition );
		else if ( _t.position.x > xBoundry )
			_t.position = new Vector3( xBoundry, yPosition, zPosition );
	
	}
	
	public static float PositionX() {
		return _t.position.x;
	}
}
