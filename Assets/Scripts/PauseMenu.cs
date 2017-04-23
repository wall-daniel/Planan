using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour {

	public GameObject canvas;
	public GameObject player;

	// Use this for initialization
	void Start () {
		canvas.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Escape)) {
			if(canvas.active) {
				canvas.SetActive(false);
				Time.timeScale = 1;
				player.GetComponent<PlayerMovement>().enabled = true;
			} else {
				canvas.SetActive(true);
				Time.timeScale = 0;
				player.GetComponent<PlayerMovement>().enabled = false;
			}
		}
	}

	public void clickResume() {
		canvas.SetActive(false);
		Time.timeScale = 1;
		player.GetComponent<PlayerMovement>().enabled = true;
	}

	public void clickQuit() {
		SceneManager.LoadScene("MainMenu");
	}
}
