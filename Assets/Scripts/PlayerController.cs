using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	// How quickly the player can move.
	public float speed = 5;

	// The rigidbody of the player (Used to apply force to the rigidbody comp)
	private Rigidbody player;

	// Use this for initialization
	void Start () {
		// Initialize the rigidbody on our player (Using this for movement :)
		player = GetComponent<Rigidbody>();
	}
	
	// FixedUpdate is called consistently on time
	void FixedUpdate() {

		/* 
			Essentially just Addforce in the direction
		   	that the player is pressing. Using AddForce.
		   	3 inputs are X Y Z. Speed is the amount of force
		   	being added to the rigidbody WHILE (button) is
		   	pressed

			We're ignore Y because that would make the ball
			levitate. We do not want that as that would be lame.
		*/

		// UP (W)
		if (Input.GetKey(KeyCode.W)) {
			player.AddForce(0, 0, speed);
		}

		// DOWN (S)
		if (Input.GetKey(KeyCode.S)) {
			player.AddForce(0, 0, speed * -1);
		}

		// RIGHT (D)
		if (Input.GetKey(KeyCode.D)) {
			player.AddForce(speed, 0, 0);
		}

		// LEFT (A)
		if (Input.GetKey(KeyCode.A)) {
			player.AddForce(speed * -1, 0, 0);
		}

	}
}
