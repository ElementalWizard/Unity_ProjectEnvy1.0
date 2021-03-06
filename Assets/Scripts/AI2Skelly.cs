using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI2Skelly : MonoBehaviour {
	private Vector3 Player;
	private Vector2 PlayerDir;
	private float Xdif,Ydif;
	public float speed;
	private Rigidbody2D rb;
	private int wall;
	private float distance;
	private bool stun;
	private float stunTime;
	private int step = 1;



	void Start()
	{
		stunTime = 0;
		stun = false;
		wall = 1 << 8;
		rb = GetComponent<Rigidbody2D> ();
	}
	void Update () {

		distance = Vector2.Distance (Player, transform.position);
		Player = GameObject.Find ("Player").transform.position;
		if (stunTime > 0) {
			stunTime -= (Time.deltaTime);
		} else {
			stun = false;
		}
		if ((distance < 2) && !stun) {
			Xdif = Player.x - transform.position.x;
			Ydif = Player.y - transform.position.y;
			PlayerDir = new Vector2 (Xdif, Ydif);
			if (!Physics2D.Raycast (transform.position, PlayerDir, 1, wall)) {
				rb.AddForce (PlayerDir.normalized * speed);
			} else {
				rb.AddForce (PlayerDir.normalized * 0);
			}
		}

	}

	void OnCollisionEnter2D( Collision2D PlayerHit){
		if (PlayerHit.gameObject.tag == "Player") {
			stun = true;
			stunTime = 0.3f;
		}
	}
}
