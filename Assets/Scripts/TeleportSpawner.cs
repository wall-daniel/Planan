using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportSpawner : MonoBehaviour
{

    public GameObject teleportFuel;
    public GameObject teleportMetal;
    public GameObject teleportFood;
    public GameObject teleportTech;
    public int randomValue = 1;
    public double timerReset = 10f;


    private double timer;
    


    void Start()
    {
        teleportFood.SetActive(false);
        teleportMetal.SetActive(false);
        teleportTech.SetActive(false);
        teleportFuel.SetActive(false);
        timer = timerReset;
    }

    
    void Update()
    {
        timer -= Time.deltaTime;


           if (timer < 0)
            {
            timer = timerReset;
            randomValue = (int) Random.Range(0f, 7f);
            if (randomValue == 0f)
                                {
                teleportFood.SetActive(false);
                teleportMetal.SetActive(false);
                teleportTech.SetActive(false);
                teleportFuel.SetActive(false);
            } else if(randomValue == 1f)
            {
                teleportFood.SetActive(true);
                teleportMetal.SetActive(false);
                teleportTech.SetActive(false);
                teleportFuel.SetActive(false);
            }else if(randomValue == 2f)
            {
                teleportFood.SetActive(false);
                teleportMetal.SetActive(true);
                teleportTech.SetActive(false);
                teleportFuel.SetActive(false);
            }else if(randomValue == 3f)
            {
                teleportFood.SetActive(false);
                teleportMetal.SetActive(false);
                teleportTech.SetActive(true);
                teleportFuel.SetActive(false);
            }else if (randomValue == 4f)
            {
                teleportFood.SetActive(false);
                teleportMetal.SetActive(false);
                teleportTech.SetActive(false);
                teleportFuel.SetActive(true);
            }
            else if (randomValue == 5f)
            {
                teleportFood.SetActive(true);
                teleportMetal.SetActive(true);
                teleportTech.SetActive(true);
                teleportFuel.SetActive(true);
            }
            else if (randomValue == 6f)
            {
                teleportFood.SetActive(false);
                teleportMetal.SetActive(true);
                teleportTech.SetActive(false);
                teleportFuel.SetActive(true);
            }
            else if (randomValue == 7f)
            {
                teleportFood.SetActive(true);
                teleportMetal.SetActive(false);
                teleportTech.SetActive(true);
                teleportFuel.SetActive(false);
            }
        }

    }

    

}
