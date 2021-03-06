using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class cutWire : MonoBehaviour {

	public static bool isRedCut = false;
	public bool isBlueCut = false;
	public static bool isYellowCut = false;
	public Animator blueAnim, redAnim, yellowAnim ;
	//public TextMeshProUGUI endGameText;
	private AudioSource[] allAudioSources;

	// Use this for initialization
	void Start () {
		blueAnim.enabled = false;
		redAnim.enabled = false;
		yellowAnim.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	// red blue yellow
	 
	public void cutYellow(){
		if(!isYellowCut && isBlueCut){
			yellowAnim.enabled = true;
			isYellowCut = true;
			Debug.Log("yellow wire");
			//endGameText.text = "Nice job. You saved the world.";
			// you won
			youWon();
			StopAllAudio();
		}else if(!isBlueCut){
			gameOver();
		}
	}
	
	public void cutBlue(){
		if(!isBlueCut && isRedCut){
			isBlueCut = true;
			blueAnim.enabled = true;
			Debug.Log("blue wire");
		}else if(!isRedCut){
			gameOver();
		}
	}

	public void cutRed(){
		if(!isRedCut){
			isRedCut = true;
			redAnim.enabled = true;
			Debug.Log("red wire");
		}
	}

	public void gameOver(){
		GameOverPopup.gameOverCube.active = true;
		StopAllAudio();
	}

	public void youWon(){
		GameOverPopup.gameWonCube.active = true;
	}
	void StopAllAudio() {
		allAudioSources = FindObjectsOfType(typeof(AudioSource)) as AudioSource[];
		foreach( AudioSource audioS in allAudioSources) {
			audioS.Stop();
		}
	}
}
