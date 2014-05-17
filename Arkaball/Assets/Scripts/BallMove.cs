using UnityEngine;
using System.Collections;

public class BallMove : MonoBehaviour {

	public float speed;
	public AudioClip pong, explosion;

	private Rigidbody2D thisRigidbody;
	private AudioSource thisAudio;
	private bool paused = false; 

	void Awake () {
		thisRigidbody = rigidbody2D; //Caching the rigidbody2D
		thisAudio = audio;
	
		thisRigidbody.velocity = Vector2.up*speed; //Velocity of the ball
	}

	void Paused( bool pause)
	{
		if(Input.GetKey(KeyCode.Space))
		{ 
			if(!pause)
			{ 
				Time.timeScale = 0; 
				paused=true; 
			}
			else
			{ 
				Time.timeScale = 1; 
				paused=false; 
			}
		} 
	}

	void Update()
	{
		Paused (paused);
	}

	void OnCollisionEnter2D(Collision2D collision)
	{

		switch(collision.gameObject.name) //If collisions...
		{
		case "Bot": //Lose and reload the level
		{	
			Lives.currentLives--; 
			Application.LoadLevel(Application.loadedLevel);
			if (Lives.currentLives == 0)
				Application.LoadLevel("EndGame");
		}
			break;
		case "Block": //Sound of explosion of the block
			thisRigidbody.velocity = thisRigidbody.velocity*1.05f;
			thisAudio.PlayOneShot(explosion);
			break;
		case "Player": //Sound of bounce and increment the veolcity
			thisAudio.PlayOneShot(pong);
			break;
		}
	}
}
