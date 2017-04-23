
using UnityEngine;

public class IconsColliding : MonoBehaviour {

	public GameObject inventory;
	
	void Start () {
		
	}

	void OnTriggerEnter2D(Collider2D collider) {
		if(collider.gameObject.CompareTag("supplies")) {
			switch(collider.gameObject.name) {
				case "fuel" :
					inventory.GetComponent<Inventory>().addSupply(Inventory.supplies.FUEL);
					break;
				case "food" :
					inventory.GetComponent<Inventory>().addSupply(Inventory.supplies.FOOD);
					break;
				case "metal":
					inventory.GetComponent<Inventory>().addSupply(Inventory.supplies.METAL);
					break;
				case "tech":
					inventory.GetComponent<Inventory>().addSupply(Inventory.supplies.TECH);
					break;
			}
			Destroy(collider.gameObject);
		}
	}
}
