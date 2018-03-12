
using UnityEngine;

public class Interactable : MonoBehaviour {

	public float radius = 3f;

	private bool isFocus = false;
	private Transform player;


	protected virtual void Interact (){


	}

	public void FixedUpdate(){

		if (isFocus) {
		
			float distance = Vector3.Distance (player.position, transform.position);
			if (distance <= radius) {
				Interact();

			}
		}

	}


	public void OnFocused(Transform playerTransform){
		isFocus = true;
		player = playerTransform;

	}

	public void OnDeFocused(Transform playerTransform){
		isFocus = false;
		player = null;
	
	}

	void OnDrawGizmosSelected(){

		Gizmos.color = Color.yellow;
		Gizmos.DrawWireSphere (transform.position, radius);
	}
}
