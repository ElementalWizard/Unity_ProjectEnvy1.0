using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorOpen : Interactable {

	public int taps;
	public Sprite sprite;
	private bool stun;
	private float stunTime;
	public string level = "Cave1";
	public Sprite[] sprites;

	// Use this for initialization
	void Start () {
		taps = 0;
		stunTime = 0;
		stun = false;
	}

	protected override void Interact(){
		if(Input.GetKeyDown (KeyCode.E)&&!stun){
			if (taps < 4) {
				this.GetComponent<SpriteRenderer> ().sprite = sprites [taps];

			} else {
				this.GetComponent<SpriteRenderer>().sprite = sprite;
			}
			taps = taps + 1;
			stun = true;

		}
		if (Input.GetKeyUp (KeyCode.E) && stun) {
			stun = false;
		}
		if (taps >= 5 && Input.GetKey (KeyCode.Q)) {
			SceneManager.LoadScene (level);
		}
	}

	void OnCollisionEnter2D(Collision2D coll) {
		OnFocused (coll.transform);
	}

	void OnCollisionExit2D(Collision2D coll) {
		OnDeFocused (coll.transform);
	}
	
//	// Update is called once per frame
//	void Update () {
//		if (stunTime > 0) {
//			stunTime -= (Time.deltaTime);
//		} else {
//			stun = false;
//		}
//		if (taps >= 5) {
//			this.GetComponent<SpriteRenderer>().sprite = sprite;
//		}
//	}
//	void OnCollisionStay2D(Collision2D PlayerHit) {
//		if(Input.GetKey (KeyCode.E)&&!stun){
//			taps = taps + 1;
//			stun = true;
//			stunTime = 0.3f;
//		}
//		if (taps > 5 && Input.GetKey (KeyCode.Q)) {
//			SceneManager.LoadScene (level);
//		}
//
//
//	}
}
