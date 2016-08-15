using UnityEngine;
using System.Collections;

public class DeathTriggerZombie : MonoBehaviour {


	void OnTriggerEnter2D( Collider2D activator){
		
		if (activator.GetComponent<KillablebyZombie> () != null) {
			
			Destroy (activator.gameObject);
		}
	}
}
