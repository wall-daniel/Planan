﻿using UnityEngine;

public class FauxGravity : MonoBehaviour
{

    public float maxGravDist = 4.0f;
    public float maxGravity = 35.0f;

    GameObject[] planets;

    void Start()
    {
        planets = GameObject.FindGameObjectsWithTag("Planet");
    }

    void FixedUpdate()
    {
        foreach (GameObject planets in planets)
        {
            float dist = Vector3.Distance(planets.transform.position, transform.position);
            if (dist <= maxGravDist)
            {
                Vector3 v = planets.transform.position - transform.position;
                GetComponent<Rigidbody2D>().AddForce(v.normalized * (1.0f - dist / maxGravDist) * maxGravity);
            }
        }
    }
}
