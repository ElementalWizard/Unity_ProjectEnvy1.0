using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamMovementP : MonoBehaviour {

	Transform target;

	// Use this for initialization
	void Start () {
		target = GameObject.Find ("PlayerP").transform;
	}

	// Update is called once per frame
	void Update () {
		transform.position = target.position + new Vector3 (0, 0, -5);
	}
}
