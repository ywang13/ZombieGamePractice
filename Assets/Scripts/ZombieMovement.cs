using UnityEngine;
using System.Collections;

public class ZombieMovement : MonoBehaviour {
	public float moveSpeed = 30.0f;
	public string targetTag = "Player";

	Rigidbody2D followerRigidbody;
	// Use this for initialization
	void Start () {
		followerRigidbody = GetComponent<Rigidbody2D> ();

	}

	// Update is called once per frame
	void Update () {
		
		GameObject target = GameObject.FindWithTag(targetTag);
		if(target == null){
			return;
		}

		Vector3 followDirection = target.transform.position - this.transform.position;
		followDirection.Normalize ();
		followerRigidbody.velocity = followDirection * Time.deltaTime * moveSpeed;

	}
}
