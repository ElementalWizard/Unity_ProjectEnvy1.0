﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMoving : MonoBehaviour {

	public float scrollSpeed;
	public float titleSizeZ;

	private Vector3 startPosition;

	// Use this for initialization
	void Start () {
		startPosition = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		float newPosition = Mathf.Repeat (Time.time * scrollSpeed, titleSizeZ);
		transform.position = startPosition + (-Vector3.right) * newPosition;
	}
}