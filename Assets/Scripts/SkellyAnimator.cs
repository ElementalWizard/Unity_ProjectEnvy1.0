using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkellyAnimator : MonoBehaviour {

	public Animator ani;
	private Rigidbody2D rb;
	private Vector3 Player;
	private Vector2 PlayerDir;
	private float Xdif,Ydif;
	private int wall;
	private float distance;
	private bool stun;
	private float stunTime;

	void Start () {
		stunTime = 0;
		stun = false;
		rb = GetComponent<Rigidbody2D> ();
		wall = 1 << 8;
	}
	
	void Update () {
		distance = Vector2.Distance (Player, transform.position);
		Player = GameObject.Find ("Player").transform.position;
		if (stunTime > 0) {
			stunTime -= Time.deltaTime;
		} else {
			stun = false;
		}
		Xdif = Player.x - transform.position.x;
		Ydif = Player.y - transform.position.y;
		PlayerDir = new Vector2 (Xdif, Ydif);

		if (rb.velocity.x > 0 && (Mathf.Abs(rb.velocity.x) > Mathf.Abs(rb.velocity.y))) {
			//moving mostlky right
			ani.SetBool ("Right", true);
			ani.SetBool ("Left", false);
			ani.SetBool ("Up", false);
			ani.SetBool ("Down", false);
			if (!Physics2D.Raycast (transform.position, PlayerDir, 3, wall) && !stun && distance < 2) {
				ani.SetBool ("WalkingLeft", false);
				ani.SetBool ("WalkingRight", true);
				ani.SetBool ("WalkingDown", false);
				ani.SetBool ("WalkingUp", false);
			} else {
				ani.SetBool ("WalkingLeft", false);
				ani.SetBool ("WalkingRight", false);
				ani.SetBool ("WalkingDown", false);
				ani.SetBool ("WalkingUp", false);
			}

		}else if (rb.velocity.x < 0 && (Mathf.Abs(rb.velocity.x) > Mathf.Abs(rb.velocity.y))) {
			//moving mostlky left
			ani.SetBool ("Up", false);
			ani.SetBool ("Right", false);
			ani.SetBool ("Left", true);
			ani.SetBool ("Down", false);
			if (!Physics2D.Raycast (transform.position, PlayerDir, 3, wall) && !stun&& distance < 2) {
				ani.SetBool ("WalkingLeft", true);
				ani.SetBool ("WalkingRight", false);
				ani.SetBool ("WalkingDown", false);
				ani.SetBool ("WalkingUp", false);
			} else {
				ani.SetBool ("WalkingLeft", false);
				ani.SetBool ("WalkingRight", false);
				ani.SetBool ("WalkingDown", false);
				ani.SetBool ("WalkingUp", false);
			}

		}else if (rb.velocity.y > 0 && (Mathf.Abs(rb.velocity.x) < Mathf.Abs(rb.velocity.y))) {
			//moving mostlky up
			ani.SetBool ("Left", false);
			ani.SetBool ("Right", false);
			ani.SetBool ("Up", true);
			ani.SetBool ("Down", false);
			if (!Physics2D.Raycast (transform.position, PlayerDir, 3, wall) && !stun&& distance < 2) {
				ani.SetBool ("WalkingLeft", false);
				ani.SetBool ("WalkingRight", false);
				ani.SetBool ("WalkingDown", false);
				ani.SetBool ("WalkingUp", true);
			} else {
				ani.SetBool ("WalkingLeft", false);
				ani.SetBool ("WalkingRight", false);
				ani.SetBool ("WalkingDown", false);
				ani.SetBool ("WalkingUp", false);
			}

		}else if (rb.velocity.y < 0 && (Mathf.Abs(rb.velocity.x) < Mathf.Abs(rb.velocity.y))) {
			//moving mostlky down
			ani.SetBool ("Down", true);
			ani.SetBool ("Right", false);
			ani.SetBool ("Up", false);
			ani.SetBool ("Left", false);
			if (!Physics2D.Raycast (transform.position, PlayerDir, 3, wall) && !stun&& distance < 2) {
				ani.SetBool ("WalkingLeft", false);
				ani.SetBool ("WalkingRight", false);
				ani.SetBool ("WalkingDown", true);
				ani.SetBool ("WalkingUp", false);
			} else {
				ani.SetBool ("WalkingLeft", false);
				ani.SetBool ("WalkingRight", false);
				ani.SetBool ("WalkingDown", false);
				ani.SetBool ("WalkingUp", false);
			}

			if (rb.velocity == new Vector2 (0, 0)) {
				ani.SetBool ("WalkingLeft", false);
				ani.SetBool ("WalkingRight", false);
				ani.SetBool ("WalkingDown", false);
				ani.SetBool ("WalkingUp", false);
			}
		}
	}

	void OnCollisionEnter2D( Collision2D PlayerHit){
		if (PlayerHit.gameObject.tag == "Player") {
			stun = true;
			stunTime = 1;
		}
	}

}
