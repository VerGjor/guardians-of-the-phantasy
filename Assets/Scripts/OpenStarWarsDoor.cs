using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class OpenStarWarsDoor : MonoBehaviour {

	public Animator left, right;
	public AudioSource aSource;
    public AudioClip aClip;
    public AudioClip doorClip;
    public AudioClip bombClip;
	public GameObject gameOverPopup;
	public TextMeshProUGUI endGameText;
	
	int flag = 0;
	
	// Use this for initialization
	void Start () {
		
		if(left != null){
			left.GetComponent<Animator>().enabled = false;
		}

		if(right != null){
			right.GetComponent<Animator>().enabled = false;
		}
		
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	

	public void openDoor(){

		if(OpenChest.isCardFound && flag == 0){
		
			Debug.Log("Opening the door");
			if(left != null){
				left.GetComponent<Animator>().enabled = true;
			}
			if(right != null){
				right.GetComponent<Animator>().enabled = true;
			}
			VRLookWalk.loadDW.allowSceneActivation = true;
			aSource.PlayOneShot(doorClip);
			Invoke("playBomb",2);
			flag = 1;
			
		}else{
			Debug.Log("you need a card to open the door.");
			aSource=aSource.GetComponent<AudioSource>();
			aSource.PlayOneShot (aClip);
		}
	}

	public void playBomb(){
		aSource=aSource.GetComponent<AudioSource>();
		aSource.PlayOneShot (bombClip);
		Invoke("check",90);
	}

	public void check(){
		if(!cutWire.isYellowCut){
			gameOver();
		}
	}

	public void gameOver(){
		GameOverPopup.gameOverCube.active = true;
	}
}
