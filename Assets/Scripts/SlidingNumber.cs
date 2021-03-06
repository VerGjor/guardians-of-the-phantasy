using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class SlidingNumber : MonoBehaviour {

	public AudioSource aSource;
    public AudioClip aClip;
	public TextMeshProUGUI numberText;
	Animator m_Animator;
	static int score = 0;
	int flag = 0;
	
	// Use this for initialization
	void Start () {
		m_Animator = GetComponent<Animator>();
		if(m_Animator != null){
			m_Animator.GetComponent<Animator>().enabled = false;
		}
		numberText = GameObject.Find("MainText").GetComponent<TextMeshProUGUI>() ;
		numberText.text = "0";
	}
	
	// Update is called once per frame
	void Update () {

	}
	
	

	public void addOne(){
		score ++;
		numberText.text = score + "";
		Debug.Log("addOne");
	}

	public void removeOne(){
		score --;
		numberText.text = score + "";
		Debug.Log("removeOne");
	}

	public void checkPasswordForDoor(){
		if(score == 2 && flag == 0){ // password is 2

			//SceneManager.LoadScene("StarWars", LoadSceneMode.Additive);
			
			if(aSource != null && aClip != null && flag == 0) {
				aSource.PlayOneShot (aClip);
				flag = 1;
			}

			if(m_Animator != null){
				m_Animator.GetComponent<Animator>().enabled = true;
			}
			
			Debug.Log("open the door");
		}else{
			Debug.Log("wrong password");
		}
	}
}
