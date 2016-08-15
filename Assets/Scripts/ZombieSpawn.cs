using UnityEngine;
using System.Collections;

public class ZombieSpawn : MonoBehaviour {
	public GameObject ZombieRespawn;

	public float respawninterval = 5f;

	// Use this for initialization
	void Start () {
		InvokeRepeating ("ZombieNest", respawninterval, respawninterval);
	}
	
	void ZombieNest () {
		Instantiate (ZombieRespawn, transform.position, Quaternion.Euler (0f, 0f, 0f));
	}
}
