﻿using UnityEngine;
using System.Collections;

public class lightUp : MonoBehaviour {
	public Material lightUpMaterial;
	public GameObject gameLogic;
	private Material defaultMaterial;

	// Use this for initialization
	void Start () {
		defaultMaterial = GetComponent<MeshRenderer>().material; //Save our initial material as the default
        GetComponentInChildren<ParticleSystem>().enableEmission=false; //Start without emitting particles
        
        gameLogic = GameObject.Find ("gameLogic");
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void patternLightUp(float duration) { //The lightup behavior when displaying the pattern
		StartCoroutine(lightFor(duration));
	}


	public void gazeLightUp() {
        GetComponent<MeshRenderer>().material = lightUpMaterial; //Assign the hover material
        GetComponentInChildren<ParticleSystem>().enableEmission = true; //Turn on particle emmission
        GetComponent<GvrAudioSource>().Play();

		gameLogic.GetComponent<GameLogic>().playerSelection(this.gameObject);


	}
	public void playerSelection() {
		gameLogic.GetComponent<GameLogic>().playerSelection(this.gameObject);
		this.GetComponent<GvrAudioSource>().Play();
	}
	public void aestheticReset() {
        GetComponent<MeshRenderer>().material = defaultMaterial; //Revert to the default material
        GetComponentInChildren<ParticleSystem>().enableEmission = false; //Turn off particle emission
	}

	public void patternLightUp() { //Lightup behavior when the pattern shows.
        GetComponent<MeshRenderer>().material = lightUpMaterial; //Assign the hover material
        GetComponentInChildren<ParticleSystem>().enableEmission = true; //Turn on particle emmission
        GetComponent<GvrAudioSource>().Play (); //Play the audio attached
	}


	IEnumerator lightFor(float duration) { //Light us up for a duration.  Used during the pattern display
		patternLightUp ();
		yield return new WaitForSeconds(duration-.1f);
		aestheticReset ();
	}
}
