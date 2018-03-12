using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BobStoper : MonoBehaviour {

	private BoxCollider2D bx;

	// Use this for initialization
	void Start () {
		bx = GetComponent<BoxCollider2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D other){
		if (other.tag != "Player") {
			bx.isTrigger = false;
		}
	}

	void OnCollisionEnter2D(Collision2D coll) {
		if (coll.gameObject.tag == "PlayerP") {
			bx.isTrigger = true;
		}
	}
}
