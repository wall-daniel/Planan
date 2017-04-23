using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IconsColliding : MonoBehaviour {

	public Rigidbody2D rb2d;

	// Use this for initialization
	void Start () {
		
	}

	void OnTriggerEnter2D(Collider2D collider) {
		Debug.Log("works");
		if(collider.gameObject.tag == ("supplies")) {
			Debug.Log("got em");
		}
	}
}
