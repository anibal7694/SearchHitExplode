using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CloseGame : MonoBehaviour {

	float timeLeft = 15.0f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		timeLeft -= Time.deltaTime;
		if(timeLeft <= 0)
			Application.Quit();
	}
}
