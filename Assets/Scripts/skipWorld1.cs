using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class skipWorld1 : MonoBehaviour {

	public string level = "level1";

	void Update () {
		if (Input.GetKey (KeyCode.T)) {
			SceneManager.LoadScene (level);
		}
	}
}
