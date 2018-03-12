using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TwoDAnimation : MonoBehaviour {

	public Animator anim;
	public Material mat;
	private string level = "lelev1";

	// Use this for initialization
	void Start () {
		//anim = gameObject.GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		
		if (Input.GetKey (KeyCode.A)) {
			anim.SetBool ("Left", true);
			anim.SetBool ("Right", false);
		}
		else if (Input.GetKey (KeyCode.D)) {
			anim.SetBool ("Right", true);
			anim.SetBool ("Left", false);
		}
		if (Input.GetKeyDown (KeyCode.A)) {
			anim.SetBool ("WalkLeft", true);
		}
		else if (Input.GetKeyDown (KeyCode.D)) {
			anim.SetBool ("WalkRight", true);
		}

		if (Input.GetKeyUp (KeyCode.A)) {

			anim.SetBool ("WalkLeft", false);
		}
		else if (Input.GetKeyUp (KeyCode.D)) {

			anim.SetBool ("WalkRight", false);
		}
	}
}
