using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class OpenDrawer : MonoBehaviour {

	public GameObject key;
	public Animator m_Animator;
	public static bool isOpen = false;
	public EventTrigger trigger;
	public AudioSource aSource;
    public AudioClip aClip;

	// Use this for initialization
	void Start () {
		if(m_Animator != null){
			m_Animator.GetComponent<Animator>().enabled = false;
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void openDrawer(){
		Debug.Log("Open drawer called");
		if(!isOpen){
			m_Animator.GetComponent<Animator>().enabled = true;
			trigger.enabled = false;
			m_Animator.Play("openDrawer");
			isOpen = true;
			Invoke("myMethod",2);
			Invoke("playFoundCard", 1);
		}
	}

	public void myMethod(){
		key.active = false;
	}

	public void closeDrawer(){
		if(isOpen && m_Animator != null){
			// close 
			m_Animator.Play("closeDrawer");
			Debug.Log("close drawer");
			isOpen = false;
		}
	}

	public void playFoundCard(){
		aSource=aSource.GetComponent<AudioSource>();
		aSource.PlayOneShot (aClip);
	}
}
