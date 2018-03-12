using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordAttack : MonoBehaviour {

	public GameObject explosion;

	void OnTriggerEnter2D(Collider2D other){
		if (other.tag == "Enemy") {
			Instantiate (explosion, other.transform.position, Quaternion.identity);
			Destroy (other.gameObject);
		}
	}
}
