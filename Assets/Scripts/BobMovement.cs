using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BobMovement : PhysicsObject {

	public float maxSpeed = 7;
	public float jumpTakeOffSpeed = 7;
	private SpriteRenderer spriteRenderor;
	private Animator anim;

	private bool stun;
	private float stunTime;
	private int ranint = 0;
	private int counter = 0;
	private int lastint = 0;



	// Use this for initialization
	void Awake () 
	{
		spriteRenderor = GetComponent<SpriteRenderer> ();
		anim = GetComponent<Animator> ();
		stunTime = 0;
		stun = false;

	}

	protected override void ComputeVelocity()
	{
		if (stunTime > 0) {
			stunTime -= (Time.deltaTime);
		} else {
			stun = false;

			if (ranint == lastint) {
				counter++;
				if (counter == 4) {
					stun = true;
					stunTime = 0.3f;
					ranint = -ranint;
				}
			}

				lastint = ranint;
		}

		Vector2 move = Vector2.zero;
		if (!stun ) {
			ranint = Random.Range (0, 3);
			stun = true;
			stunTime = 0.3f;
		
		}
		if (ranint == 0) {
			move.x = Vector2.right.x/2;
			anim.SetBool ("WalkingRight", true);
		} else if (ranint == 1) {
			move.x = -Vector2.right.x/2;
			anim.SetBool ("WalkingRight", true);
		} else {
			move = Vector2.zero;
			anim.SetBool ("WalkingRight", false);
		}

        if(move.x > 0.01f)
        {
			if(spriteRenderor.flipX == true)
            {
				spriteRenderor.flipX = false;
            }
        } 
        else if (move.x < -0.01f)
        {
			if(spriteRenderor.flipX == false)
            {
				spriteRenderor.flipX = true;
            }
        }


		targetVelocity = move * maxSpeed;
	}
}
