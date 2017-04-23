using UnityEngine;
using UnityEngine.SceneManagement;


public class GoToMainMenu : MonoBehaviour {

	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.Space)) {
			SceneManager.LoadScene("MainMenu");
		}
	}
}
