using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Inventory : MonoBehaviour {

	public GameObject music;
	private bool fuel = false;
	private bool metal = false;
	private bool food = false;
	private bool tech = false;

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

		music.GetComponent<soundEffect>().playing = true;

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
