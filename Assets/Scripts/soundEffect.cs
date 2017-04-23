using UnityEngine;

public class soundEffect : MonoBehaviour {

	public bool playing = false;
	public AudioSource audio;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(playing) {
			audio.Play();
			playing = false;
		}
	}
}
