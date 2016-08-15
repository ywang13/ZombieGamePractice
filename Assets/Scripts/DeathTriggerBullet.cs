using UnityEngine;
using System.Collections;

public class DeathTriggerBullet : MonoBehaviour {
	

	void OnTriggerEnter2D( Collider2D activator){
		
		if (activator.GetComponent<KillablebyBullet> () != null) {
			
			Destroy (activator.gameObject);
		}
	}
}
