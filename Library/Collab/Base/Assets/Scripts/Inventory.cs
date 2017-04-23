using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Inventory : MonoBehaviour {

	private bool fuel = false;
	private bool metal = false;
	private bool food = false;
	private bool tech = false;


    private int Counter = 0;
    public GameObject Step1;
    public GameObject Step2;
    public GameObject Step3;
    public GameObject Step4;

    public Text[] textboxes;

	public enum supplies {
		FUEL, METAL, FOOD, TECH
	}

	// Use this for initialization
	void Start () {
		textboxes[0].text = "X";
		textboxes[1].text = "X";
		textboxes[2].text = "X";
		textboxes[3].text = "X";
	}

    public void Count()
    {
        if (food)
            Counter++;
        if (fuel)
            Counter++;
        if (metal)
            Counter++;
        if (tech)
            Counter++;
    }

    public void Update()
    {
        if(Counter == 1)
        {
            Step1.SetActive(true);
        }
        if(Counter == 3)
        {
            Step2.SetActive(true);
        }
        if (Counter == 6)
        {
            Step3.SetActive(true);
        }
        if(Counter == 10)
        {
            Step4.SetActive(true);
        }
    }



    public void addSupply(supplies supply) {
		switch(supply) {
			case supplies.FUEL:
				fuel = true;
				textboxes[0].text = "✔";
				break;
			case supplies.METAL:
				metal = true;
				textboxes[2].text = "✔";
				break;
			case supplies.FOOD:
				food = true;
				textboxes[1].text = "✔";
				break;
			case supplies.TECH:
				tech = true;
				textboxes[3].text = "✔";
				break;

               
		}
        Count();

		// once all items have been collected, you win
		if(hasAllSupplies()) {
			SceneManager.LoadScene("Winner");
		}
	}

	public bool hasAllSupplies() {
		if(fuel && food && metal && tech) {
			return true;
		}

		return false;
	}
}
