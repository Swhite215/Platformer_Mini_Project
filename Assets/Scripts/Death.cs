using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death : MonoBehaviour {

	public AudioClip deathClip;

	void OnCollisionEnter2D (Collision2D col) {
		if (col.gameObject.tag == "Player") {
			Debug.Log (gameObject.name + "killed player");
			AudioSource.PlayClipAtPoint (deathClip, transform.position, 1.0f);
			GameManager.Death ();
		} else {
			Object.Destroy (col.gameObject);
		}
	}
}
