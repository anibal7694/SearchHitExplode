using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class YouLost : MonoBehaviour {

    public Button Restart1;
    public Button MainMenu;
    public Button ExitGame;
    // Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown("r"))
            RestartLevel();
        if (Input.GetKeyDown("m"))
            MenuMain();
        if (Input.GetKeyDown("q"))
            Exit();
	}
    public void RestartLevel()
    {
        Application.LoadLevel(1);
    }
    public void MenuMain()
    {
        Application.LoadLevel(0);
    }
    public void Exit()
    {
        Application.Quit();
    }
}
