using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour {

	public float Health = 100f;
	private SpriteRenderer healthBar;
	private Vector3 healthScale;
	private Rigidbody2D rb;
	private float hitTime;

	public Material Default,hit;

	// Use this for initialization
	void Start () {
		
		healthBar = GameObject.Find ("Health").GetComponent<SpriteRenderer> ();
		healthScale = healthBar.transform.localScale;
		rb = GetComponent<Rigidbody2D> ();


	}
	
	// Update is called once per frame
	void Update () {
		if (Health <= 0) {
			Application.Quit ();

		}
		if (Health > 100) {
			Health = 100;
		}
		HealthUpdate ();

		if (hitTime + 0.06f < Time.time) {
			GetComponent<SpriteRenderer> ().material = Default;

		}
	}

	void HealthUpdate(){
		healthBar.transform.localScale = new Vector3 (healthScale.x * Health * 0.01f, 1, 1);

	}

	void OnCollisionStay2D(Collision2D Enemyhit){
		if (Enemyhit.gameObject.tag == "Enemy") {
			if (hitTime + 0.5f < Time.time) {
				
				hitTime = Time.time;
				Health -= 5;

				GetComponent<SpriteRenderer> ().material = hit;

				float verticalPush = Enemyhit.gameObject.transform.position.y - transform.position.y, horizontalPush = Enemyhit.gameObject.transform.position.x - transform.position.x;

				rb.AddForce (new Vector2 (-horizontalPush * 750, -verticalPush * 750));
			}
		}
	}

}
