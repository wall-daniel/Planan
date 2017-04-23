using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour {

	public bool playing = false;
	public float pitch = 2f;
	public AudioSource musicSource;

	// Use this for initialization
	void Start () {
		musicSource.pitch = pitch;
	}
	
	// Update is called once per frame
	void Update () {
		if(!musicSource.isPlaying) {
			musicSource.Play();
		}
	}
}
