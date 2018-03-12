using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI1Skell : MonoBehaviour {
	private Vector3 Player;
	private Vector2 PlayerDir;
	private float Xdif,Ydif;
	public float speed;
	private Rigidbody2D rb;
	private int wall;
	private float distance;
	private bool stun;
	private float stunTime;
	private bool startFinish = false;
	private int step = 1;
	public Animator anim;


	void Start()
	{
		stunTime = 0;
		stun = false;
		wall = 1 << 8;
		rb = GetComponent<Rigidbody2D> ();
	}
	void Update () {
		if (startFinish) {
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
		} else {

			if (transform.position.y < 21.67f&& step ==3) {
				
				rb.AddForce (Vector2.up * speed);
			}else if (transform.position.y > 21.67f && step ==3) {
				startFinish = true;
			}
			if (transform.position.x > -4.95f && step == 2) {
				
				rb.AddForce (Vector2.left * speed);
			} else if (transform.position.x< -4.95f && step == 2) {
				step = 3;
			}

			if (transform.position.y < 20.06f && step == 1) {
				
				rb.AddForce (Vector2.up * speed);

			} else if (transform.position.y > 20.06f && step == 1) {
				step= 2;

			}

			if (anim.GetBool("Up")){
				anim.SetBool ("WalkingLeft", false);
				anim.SetBool ("WalkingRight", false);
				anim.SetBool ("WalkingDown", false);
				anim.SetBool ("WalkingUp", true);

			}if (anim.GetBool("Down")){
				anim.SetBool ("WalkingLeft", false);
				anim.SetBool ("WalkingRight", false);
				anim.SetBool ("WalkingDown", true);
				anim.SetBool ("WalkingUp", false);

			}if (anim.GetBool("Left")){
				anim.SetBool ("WalkingLeft", true);
				anim.SetBool ("WalkingRight", false);
				anim.SetBool ("WalkingDown", false);
				anim.SetBool ("WalkingUp", false);

			}if (anim.GetBool("Right")){
				anim.SetBool ("WalkingLeft", false);
				anim.SetBool ("WalkingRight", true);
				anim.SetBool ("WalkingDown", false);
				anim.SetBool ("WalkingUp", false);

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
