using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TeleportToJunglePlat : MonoBehaviour {

	public string level = "JunglePlatform";

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


	void OnCollisionEnter2D(Collision2D coll) {
		SceneManager.LoadScene (level);
	}
}
