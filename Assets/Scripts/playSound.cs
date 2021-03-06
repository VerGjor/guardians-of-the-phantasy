using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playSound : MonoBehaviour {
	
	public AudioSource aSource;
    public AudioClip aClip;
	
	int flag = 0;

    public void playSoundEffect(){   
		if(flag == 0){
			flag = 1;
			Debug.Log ("Start music");
			aSource=aSource.GetComponent<AudioSource>();
			aSource.PlayOneShot (aClip);
		}   
    }

    public void stopSoundEffect(){
        Debug.Log ("Stop music");
        aSource=aSource.GetComponent<AudioSource>();
        aSource.Stop ();
    }    
}
