using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class CreditsManager : MonoBehaviour {
	
	public Canvas canvas;
	public GameObject textBox;
	public Text theText;
	
	private double time;

	public TextAsset textFile;
	public string[] lines;

	public int currentLine;
	public int endAtLine;

	public GameObject player;

	// Use this for initialization
	void Start () {

		if(textFile != null) {
			lines = textFile.text.Split('\n');
		}
		endAtLine = lines.Length - 1;
		// player.GetComponent<PlayerMovement>().enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		if(currentLine <= endAtLine)
			theText.text = lines[currentLine];

		if((Input.GetKeyDown(KeyCode.Space) || time > 1.5f) && currentLine <= endAtLine) {
			theText.CrossFadeAlpha(0.3f, 0.0f, true);

			if(currentLine == 0) {
				currentLine++;
				gameObject.SetActive(true);
			} else {
				currentLine++;
			}

			theText.CrossFadeAlpha(1.0f, 0.5f, true);
			time = 0;
		}

		if(currentLine > endAtLine && Input.GetKeyDown(KeyCode.Space)) {
			SceneManager.LoadScene("MainMenu");
		}

		time += Time.deltaTime;
	}
}
