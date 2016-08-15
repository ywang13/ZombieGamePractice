using UnityEngine;
using System.Collections;

public class PlayerFire : MonoBehaviour {

	public GameObject bulletPrefab;
	public float FireDelay = 0.25f;
	public Transform bulletStartTransform;
	float cooldownTimer = 0;

	// Update is called once per frame
	void Update () {
		cooldownTimer -= Time.deltaTime;


		if (Input.GetButton("Fire1") && cooldownTimer <= 0) {
			cooldownTimer = FireDelay;


		    // instantiate the bullet, set its rotation to the player's up rotation
			GameObject bullet = (GameObject) Instantiate(bulletPrefab, bulletStartTransform.position, 
				transform.rotation);
			bullet.layer = gameObject.layer;
			}

		}

}
