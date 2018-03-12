using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour {

	public Animator anim;
	public Material mat;

	void Start () {
		anim = GetComponent<Animator> ();

	}
	
	void Update () {



		if (Input.GetKey (KeyCode.A)) {
			anim.SetBool ("Left", true);
			anim.SetBool ("Right", false);
			anim.SetBool ("Up", false);
			anim.SetBool ("Down", false);
		}
		if (Input.GetKey (KeyCode.S)) {
			anim.SetBool ("Down", true);
			anim.SetBool ("Right", false);
			anim.SetBool ("Up", false);
			anim.SetBool ("Left", false);
		}
		if (Input.GetKey (KeyCode.D)) {
			anim.SetBool ("Right", true);
			anim.SetBool ("Left", false);
			anim.SetBool ("Up", false);
			anim.SetBool ("Down", false);
		}
		if (Input.GetKey (KeyCode.W)) {
			anim.SetBool ("Up", true);
			anim.SetBool ("Right", false);
			anim.SetBool ("Left", false);
			anim.SetBool ("Down", false);
		}
		if (Input.GetKeyDown (KeyCode.A)) {
			anim.SetBool ("WalkLeft", true);
		}
		if (Input.GetKeyDown (KeyCode.S)) {
			anim.SetBool ("WalkDown", true);
		}
		if (Input.GetKeyDown (KeyCode.D)) {
			anim.SetBool ("WalkRight", true);
		}
		if (Input.GetKeyDown (KeyCode.W)) {
			anim.SetBool ("WalkUp", true);
		}


		if (Input.GetKeyUp (KeyCode.A)) {
	
			anim.SetBool ("WalkLeft", false);
		}
		if (Input.GetKeyUp (KeyCode.S)) {
	
			anim.SetBool ("WalkDown", false);
		}
		if (Input.GetKeyUp (KeyCode.D)) {
			
			anim.SetBool ("WalkRight", false);
		}
		if (Input.GetKeyUp (KeyCode.W)) {

			anim.SetBool ("WalkUp", false);
		}

	}
}
