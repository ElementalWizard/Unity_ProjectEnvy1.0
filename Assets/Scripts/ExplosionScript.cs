using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Invoke ("Die", 0.50f);
	}
	

	void Die () {
		Destroy(this.gameObject);
	}
}
