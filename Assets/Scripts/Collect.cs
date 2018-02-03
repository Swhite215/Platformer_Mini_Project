using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collect : MonoBehaviour {
	public int points;

	public AudioClip coinSound;

	void OnTriggerEnter2D (Collider2D coll) {
		AudioSource.PlayClipAtPoint (coinSound, transform.position, 1.0f);

		GameManager.AddScore (points);
		Object.Destroy (gameObject);
	}
}
