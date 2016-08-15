using UnityEngine;
using System.Collections;

public class LookAtCursor : MonoBehaviour {

	Vector3 cursorPositionInWorld;
	Vector3 lookDirection;
	Rigidbody2D myRigidbody;

	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {
		cursorPositionInWorld = Camera.main.ScreenToWorldPoint (Input.mousePosition);
		lookDirection = cursorPositionInWorld - transform.position;
		// set the z to 0f so that the camera can see it
		lookDirection.z = 0f;
		transform.up = lookDirection;
	}
}
