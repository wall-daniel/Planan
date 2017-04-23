using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndScreenSpaceMovement : MonoBehaviour {

    public Rigidbody2D rb;
    public float scrollSpeed;

	void Start () {
        rb = GetComponent<Rigidbody2D>();
	}
	
	
	void Update () {
        rb.transform.Translate(0, -1*scrollSpeed, 0);
	}
}
