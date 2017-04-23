using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Timer : MonoBehaviour {


	public double time = 15;
	public Text theText;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(time > 0) {
			time -= Time.deltaTime;
			theText.text = ((int) time).ToString();
		} else {
			// time is done, you've lost
			SceneManager.LoadScene("GameOver");
		}
	}
}
