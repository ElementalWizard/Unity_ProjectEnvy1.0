using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TeleportChest : MonoBehaviour {

	public Sprite sp;
	public Collider2D coll;
	public string level = "Platform";
	private SpriteRenderer ssp;

	// Use this for initialization
	void Start () {
		ssp = GetComponent<SpriteRenderer> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnCollisionStay2D(Collision2D coll) {
		if (Input.GetKey (KeyCode.E)) {
			ssp.sprite = sp;
			Invoke ("Load", 0.5f);
		}
	}

	void Load(){
		SceneManager.LoadScene (level);
	}


}
