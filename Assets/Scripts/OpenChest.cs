using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenChest : MonoBehaviour {

	public Animator m_Animator;
	public GameObject creditCard;
	public static bool isCardFound = false;
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

	public void openChest(){
		if(m_Animator != null && OpenDrawer.isOpen){
			m_Animator.GetComponent<Animator>().enabled = true;
			Invoke("getCreditCard", 3);
			
		}else{
			// play sound it is locked
			aSource=aSource.GetComponent<AudioSource>();
			aSource.PlayOneShot (aClip);
		}
	}

	private void getCreditCard(){
		if(creditCard != null){
			creditCard.active = false;
			isCardFound = true;
		}
	}
}
