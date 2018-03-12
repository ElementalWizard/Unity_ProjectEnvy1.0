using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteScript : MonoBehaviour {

	public GameObject[] objects;

	void OnEnable () {

		for (int i = 0; i < objects.Length; i++) {
			Destroy (objects [i].gameObject);
		}

	}
}
