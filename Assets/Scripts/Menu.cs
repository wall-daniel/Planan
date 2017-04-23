using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {


	// Use this for initialization
	void Start () {
	}
	
	
	// when start button is pressed
	public void clickStart() {
		SceneManager.LoadScene("scene");
	}

	// when quiting, I believe you need to build project in 
	// order for this to work
	public void clickQuit() {
		Application.Quit();
	}
}
