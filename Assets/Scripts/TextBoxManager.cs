using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class TextBoxManager : MonoBehaviour {
	
	public GameObject timer;
	public Canvas canvas;
	public GameObject textBox;
	public Text theText;
	
	public TextAsset textFile;
	public string[] lines;

	public int currentLine;
	public int endAtLine;
	public bool startHidden;
	public bool credits;

	public GameObject player;

	// Use this for initialization
	void Start () {

		if(textFile != null) {
			lines = textFile.text.Split('\n');
		}
		endAtLine = lines.Length - 1;

		if(startHidden) {
			textBox.SetActive(false);
		}
		// Time.timeScale = 0;
		player.GetComponent<PlayerMovement>().enabled = false;
		timer.GetComponent<Timer>().enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		theText.text = lines[currentLine];

		if(Input.GetKeyDown(KeyCode.Space) && gameObject.active == true) {
			theText.CrossFadeAlpha(0.3f, 0.0f, true);

			if(currentLine == 0) {
				currentLine++;
				gameObject.SetActive(true);
				Time.timeScale = 0;
			} else {
				currentLine++;
			}

			if(currentLine > endAtLine) {
				gameObject.SetActive(false);
				Time.timeScale = 1;
				player.GetComponent<PlayerMovement>().enabled = true;
				timer.GetComponent<Timer>().enabled = true;
			}

			theText.CrossFadeAlpha(1.0f, 0.5f, true);
		}
	}
}
