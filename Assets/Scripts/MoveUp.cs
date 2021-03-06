using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveUp : MonoBehaviour {

   
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void MoveBoxUp()
    {
        //calculate distance
        
        GameObject go = GameObject.FindGameObjectWithTag("Player"); //tag the element first
        Transform player = go.transform;
        
        Transform t = this.transform;
        float d = Vector3.Distance(player.position, t.position);

        if (Mathf.Abs(d) < 2) {
            transform.position += new Vector3(0.0f, 1.0f, 0.0f);
        }
        
    }
}
