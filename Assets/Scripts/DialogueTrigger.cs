using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : Interactable {

	public Dialogue dialogue;


	private bool stun;




	protected override void Interact(){

	
		if(Input.GetKeyDown (KeyCode.E)&&FindObjectOfType<DialogueManager> ().isFinished){
			
			TriggerDialogue ();


		}


	}


	void OnCollisionEnter2D(Collision2D coll) {
		OnFocused (coll.transform);
	}

	void OnCollisionExit2D(Collision2D coll) {
		OnDeFocused (coll.transform);
		FindObjectOfType<DialogueManager> ().EndDialogue ();
	}

	public void TriggerDialogue(){
	

		FindObjectOfType<DialogueManager> ().startDialogue(dialogue);

	
	}


}


