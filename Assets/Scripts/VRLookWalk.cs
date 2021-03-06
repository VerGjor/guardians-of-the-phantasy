using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VRLookWalk : MonoBehaviour {

    public Transform vrCamera;
	
	public static AsyncOperation loadSW, loadDW;

    public float toggleAngle = 20.0f; // najdi najdobar agol i brzina

    public float speed = 10.0f; 

    public bool moveForward;
	
	public bool loadDWFlag = true;

    private CharacterController cc;
	
	void Awake(){
		 StartCoroutine(wait());
	}

	// Use this for initialization
	void Start () {
        cc = GetComponent<CharacterController>();
	}
	
	IEnumerator wait(){
		 Application.backgroundLoadingPriority = ThreadPriority.High;
		 loadSW = SceneManager.LoadSceneAsync("StarWars", LoadSceneMode.Additive);
		 loadSW.allowSceneActivation = true;
		 while (!loadSW.isDone){ 
			yield return null;
		 } 
	}
	
	IEnumerator waitDW(){
		 Application.backgroundLoadingPriority = ThreadPriority.High;
		 loadDW = SceneManager.LoadSceneAsync("DoctorWho", LoadSceneMode.Additive);
		 loadDW.allowSceneActivation = false;
		 while (!loadDW.isDone){ 
			yield return null;
		 } 
	}
	
	// Update is called once per frame
	void Update () {
        if (vrCamera.eulerAngles.x >= toggleAngle && vrCamera.eulerAngles.x < 90) {
            moveForward = true;
        }
        else
        {
            moveForward = false;
        }

        if (moveForward)
        {
            Vector3 forward = vrCamera.TransformDirection(Vector3.forward);
            cc.SimpleMove(forward * speed);
        }
		
		if(loadSW.isDone && loadDWFlag){
			StartCoroutine(waitDW());
			loadDWFlag = false;
		}
	
	}
}
