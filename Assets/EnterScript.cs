using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnterScript : MonoBehaviour {

    public Rigidbody2D Rb;
    public float scrollSpeed;
    private bool startscroll = true;


    public void Start()
    {
        Rb = GetComponent<Rigidbody2D>();
    }

    public void Update()
    {
        if(startscroll == false)
        {
            Rb.transform.Translate(0, -1 * scrollSpeed, 0);
        }
    }


    public void OnTriggerEnter2D(Collider2D collisioninfo)
    {
        if (collisioninfo.GetComponent<Collider2D>().CompareTag("Earth"))
        {
            startscroll = false;
        }
    }
}
