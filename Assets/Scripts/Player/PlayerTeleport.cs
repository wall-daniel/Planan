using UnityEngine;
using UnityEngine.SceneManagement;

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
            if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow))
            {
                if (fuel == true)
                {
                    player.GetComponent<FakeGravityBody>().gravitychoice = 3;
                    player.velocity = new Vector2(20, 16);
                    fuel = false;
                }
                else
                {
                    player.GetComponent<FakeGravityBody>().gravitychoice = 1;
                    player.velocity = new Vector2(-20, -16);
                    fuel = true;
                }
                audioManager.GetComponent<soundEffect>().playing = true;
            }

        }

        if (other.gameObject.name == "MetalT")
        {
            if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow))
            {
                if (metal == true)
                {
                    player.GetComponent<FakeGravityBody>().gravitychoice = 2;
                    player.velocity = new Vector2(20, -16);
                    metal = false;
                }
                else
                {
                    player.GetComponent<FakeGravityBody>().gravitychoice = 1;
                    player.velocity = new Vector2(-20, 16);
                    metal = true;
                }
                audioManager.GetComponent<soundEffect>().playing = true;
            }

        }

        if (other.gameObject.name == "TechT")
        {
            
            if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow))
            {

                if (tech == true)
                {
                    player.GetComponent<FakeGravityBody>().gravitychoice = 4;
                    player.velocity = new Vector2(-20, 16);
                    tech = false;
                }
                else
                {
                    player.GetComponent<FakeGravityBody>().gravitychoice = 1;
                    player.velocity = new Vector2(20, -16);
                    tech = true;
                }
                audioManager.GetComponent<soundEffect>().playing = true;
                
            }
        }

        if (other.gameObject.name == "FoodT")
        {
            if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow))
            {
                if (food == true)
                {
                    player.GetComponent<FakeGravityBody>().gravitychoice = 5;
                    player.velocity = new Vector2(-20, -16);
                    food = false;
                }
                else
                {
                    player.GetComponent<FakeGravityBody>().gravitychoice = 1;
                    player.velocity = new Vector2(20, 16);
                    food = true;
                }
                audioManager.GetComponent<soundEffect>().playing = true;
            }
        }
    }

    public void toGameOver() {
        SceneManager.LoadScene("GameOver");
    }
}
