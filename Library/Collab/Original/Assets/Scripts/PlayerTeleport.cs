﻿using UnityEngine;

public class PlayerTeleport : MonoBehaviour {

    public Rigidbody2D player;
    public GameObject audioManager;
    bool tech = true;
    bool fuel = true;
    bool food = true;
    bool metal = true;

    public void OnTriggerStay2D(Collider2D other) {
        if (other.gameObject.name == "FuelT")
        {
            if (Input.GetKeyDown(KeyCode.W))
            {
                if (fuel == true)
                {
                    player.GetComponent<FakeGravityBody>().gravitychoice = 3;
                    player.velocity = new Vector2(10, 8);
                    fuel = false;
                }
                else
                {
                    player.GetComponent<FakeGravityBody>().gravitychoice = 1;
                    player.velocity = new Vector2(-10, -8);
                    fuel = true;
                }
                audioManager.GetComponent<AudioManager>().playing = true;
            }

        }

        if (other.gameObject.name == "MetalT")
        {
            if (Input.GetKeyDown(KeyCode.W))
            {
                if (metal == true)
                {
                    player.GetComponent<FakeGravityBody>().gravitychoice = 2;
                    player.velocity = new Vector2(10, -8);
                    metal = false;
                }
                else
                {
                    player.GetComponent<FakeGravityBody>().gravitychoice = 1;
                    player.velocity = new Vector2(-10, 8);
                    metal = true;
                }
                audioManager.GetComponent<AudioManager>().playing = true;
            }

        }

        if (other.gameObject.name == "TechT")
        {
            
            if (Input.GetKeyDown(KeyCode.W))
            {

                if (tech == true)
                {
                    player.GetComponent<FakeGravityBody>().gravitychoice = 4;
                    player.velocity = new Vector2(-10, 8);
                    tech = false;
                }
                else
                {
                    player.GetComponent<FakeGravityBody>().gravitychoice = 1;
                    player.velocity = new Vector2(10, -8);
                    tech = true;
                }
                audioManager.GetComponent<AudioManager>().playing = true;
                
            }
        }

        if (other.gameObject.name == "FoodT")
        {
            if (Input.GetKeyDown(KeyCode.W))
            {
                if (food == true)
                {
                    player.GetComponent<FakeGravityBody>().gravitychoice = 45;
                    player.velocity = new Vector2(-10, -8);
                    food = false;
                }
                else
                {
                    player.GetComponent<FakeGravityBody>().gravitychoice = 1;
                    player.velocity = new Vector2(10, 8);
                    food = true;
                }
                audioManager.GetComponent<AudioManager>().playing = true;
            }
        }
    }
}
