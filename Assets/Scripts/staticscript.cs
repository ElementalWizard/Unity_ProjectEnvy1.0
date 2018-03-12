using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class staticscript : MonoBehaviour {

	public Sprite[] sprites;
	

	void FixedUpdate () {
		Invoke ("Rendering", .33f);
	}
	void Rendering(){
	
	
		int num = Random.Range (0, 24);
		GetComponent<SpriteRenderer> ().sprite = sprites [num];

	}
}
