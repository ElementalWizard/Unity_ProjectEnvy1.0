using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Time.timeScale = 0f;
	}

	void OnDisable () {
		Time.timeScale = 1f;

	}
	void OnEnable () {
		Time.timeScale = 0f;

	}
}
