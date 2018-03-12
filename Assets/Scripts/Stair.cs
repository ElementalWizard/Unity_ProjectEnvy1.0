using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stair : MonoBehaviour {

	private float Yposition;


	// Use this for initialization
	void Start () {
		Yposition = transform.position.y;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D Enemyhit){
		if (Enemyhit.tag != "Wall") {
			if (Yposition > Enemyhit.transform.position.y) {
				if (Enemyhit.transform.position.z > transform.position.z) {
					Enemyhit.transform.position = new Vector3 (Enemyhit.transform.position.x, Enemyhit.transform.position.y, Enemyhit.transform.position.z - 1f);
				}

			}
		}

	}

	void OnTriggerExit2D(Collider2D Enemyhit){
		if (Yposition > Enemyhit.transform.position.y) {
			if (Enemyhit.transform.position.z < transform.position.z) {
				Enemyhit.transform.position = new Vector3 (Enemyhit.transform.position.x, Enemyhit.transform.position.y, Enemyhit.transform.position.z + 1f);
			}
		}
	}
}
