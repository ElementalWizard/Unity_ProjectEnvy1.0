using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereBoom : MonoBehaviour {

	public GameObject explosion;

	void OnTriggerEnter2D(Collider2D other){
		Debug.Log ("C");
		if (other.tag == "Enemy") {
			Debug.Log ("E");
			Instantiate (explosion,transform.position, Quaternion.identity);
			Destroy (other.gameObject,1.5f);
			Destroy (this.gameObject,.1f);
		}
	}
}
