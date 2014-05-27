using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float speed = 15; //Movement speed

	private Rigidbody2D thisRigidBody;

	void Awake () {
		thisRigidBody = rigidbody2D; //Caching the rigidbody2D
	}

	void FixedUpdate () {
		thisRigidBody.velocity = new Vector2(Input.GetAxis("Horizontal")*speed, 0); //Move the paddle
	} 
}
