using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour {

	public Animator animator;

	public Animator platformAnimator;

	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D coll) {
		if (coll.gameObject.tag == "Player") {
			animator.SetTrigger("Switch");
			if (platformAnimator != null) {
				platformAnimator.SetTrigger ("Move");
			}
		}
	}
}
