using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BetterJump : MonoBehaviour {

	Rigidbody2D rb;
	public float fallMultiplier = 2.5f ;
	public float lowGrav = 2f;


	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D> ();
	}


	void FixedUpdate () {
		if (rb.velocity.y < 0) {
			rb.gravityScale = fallMultiplier;
		} else if (rb.velocity.y > 0 && !Input.GetButton ("Jump")) {
			rb.gravityScale = lowGrav;

		} else {
			rb.gravityScale = 1;
		}
	}
}
