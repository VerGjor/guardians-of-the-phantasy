using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class showSpells : MonoBehaviour {

	public Animator m_Animator;
	// Use this for initialization
	void Start () {
		if(m_Animator != null){
			m_Animator.GetComponent<Animator>().enabled = false;
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void startAnimation(){
		if(m_Animator != null){
			m_Animator.GetComponent<Animator>().enabled = true;
		}
	}
}
