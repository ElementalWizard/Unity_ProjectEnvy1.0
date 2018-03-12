using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPlatformerController : PhysicsObject {

    public float maxSpeed = 7.5f;
    public float jumpTakeOffSpeed = 7;
	public GameObject DeathUI;



    // Use this for initialization
    void Awake () 
    {
 
        
    }

    protected override void ComputeVelocity()
    {
        Vector2 move = Vector2.zero;

        move.x = Input.GetAxis ("Horizontal");

        if (Input.GetButtonDown ("Jump") && grounded) {
            velocity.y = jumpTakeOffSpeed;
        } else if (Input.GetButtonUp ("Jump")) 
        {
			if (velocity.y > 0) {
				velocity.y = velocity.y * .54f;
			}
        }
			

      
        targetVelocity = move * maxSpeed;
    }
	void OnDestroy(){
		DeathUI.SetActive (true);
	}


}