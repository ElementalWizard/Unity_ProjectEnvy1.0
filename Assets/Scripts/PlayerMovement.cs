using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	public float speed;

	private Rigidbody2D rb;
	private Animator anim;
	public GameObject sword;
	public Animator anim2;


	void Start()
	{
		rb = GetComponent<Rigidbody2D> ();
		anim = GetComponent<Animator> ();

	}

	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButton (0)&& !anim2.GetBool("isOpen")) {
			if(anim.GetBool("Left")){
				anim.SetTrigger ("AttackLeft");
			}
			else if(anim.GetBool("Down")){
				anim.SetTrigger ("AttackDown");
			}
			else if(anim.GetBool("Right")){
				anim.SetTrigger ("AttackRight");
			}
			else if(anim.GetBool("Up")){
				anim.SetTrigger ("AttackUp");
			}

		}
		if (Input.GetKey (KeyCode.A)) {
			rb.AddForce (-Vector2.right * speed);
		} else if (Input.GetKey (KeyCode.D)) {
			rb.AddForce (Vector2.right * speed);
		} else if (Input.GetKey (KeyCode.S)) {
			rb.AddForce (-Vector2.up * speed);
		}else if (Input.GetKey (KeyCode.W)) {
			rb.AddForce (Vector2.up * speed);
		}

	}
}