using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour {

	private Queue<string> sentences;
	public Text nameText;
	public Text dialogueText;
	public Animator anim;
	public bool isFinished = true;

	// Use this for initialization
	void Start () {
		sentences = new Queue<string> ();
	}
	
	public void startDialogue(Dialogue dialogue){
		anim.SetBool ("isOpen", true);
		nameText.text = dialogue.name;
		sentences.Clear ();
		isFinished = false;

		foreach (string sentence in dialogue.Phrases) {
			sentences.Enqueue (sentence);
		}

		DisplayNextSentence ();
	}

	public void DisplayNextSentence(){
	
		if (sentences.Count == 0) {
		
			EndDialogue ();
			return;

		}

		string oracion = sentences.Dequeue ();
		StopAllCoroutines ();
		StartCoroutine(TypeSentence(oracion));
	}

	IEnumerator TypeSentence (string sentences){
		dialogueText.text = "";
		foreach (char item in sentences.ToCharArray()) {
			dialogueText.text += item;
			yield return null;
		}

	}

	public void EndDialogue(){
		anim.SetBool ("isOpen", false);
		dialogueText.text = "";
		nameText.text = "";
		isFinished = true;

	}

}
