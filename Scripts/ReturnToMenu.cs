using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ReturnToMenu : MonoBehaviour {

    public Button ReturnMenu;
    // Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown("m"))
            MainMenu();
	}
    public void MainMenu()
    {
        Application.LoadLevel(0);
    }
}
