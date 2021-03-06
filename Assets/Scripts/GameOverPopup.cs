using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverPopup : MonoBehaviour {
	
	public static GameObject gameOverCube, gameWonCube;
	
	void Start () {
		gameOverCube = GameObject.Find("gameOverCube");
		gameOverCube.active = false;
		gameWonCube = GameObject.Find("gameWonCube");
		gameWonCube.active = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}


}
