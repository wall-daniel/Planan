
using UnityEngine;

public class IconsColliding : MonoBehaviour {

	
	
	void Start () {
		
	}

	public void OnTriggerEnter2D(Collider2D collider) {
		Debug.Log("works");
		if(collider.gameObject.CompareTag("supplies")) {
			Debug.Log("got em");
		}
	}
}
