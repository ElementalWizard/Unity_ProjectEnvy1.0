using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Depth : MonoBehaviour {


	private float Yposition;
	public Transform transforms;
	private Vector3 pocition;


	// Update is called once per frame
	void Update () {
		Yposition = transform.position.y;
		pocition = transforms.position;
		if (Yposition > pocition.y) {
			GetComponent<SpriteRenderer> ().sortingLayerName = "Platform";
		} else {
			GetComponent<SpriteRenderer> ().sortingLayerName = "aboveHead";		}
	}
		
}
