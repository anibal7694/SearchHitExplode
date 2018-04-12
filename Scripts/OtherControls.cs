using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OtherControls : MonoBehaviour {

    public Canvas PauseMenu;
    public Button Pause;
    public Button Resume;
    public Button MainMenu;
    public Button Exit;


    // Use this for initialization
	void Start () {
        PauseMenu = PauseMenu.GetComponent<Canvas>();
        Pause = Pause.GetComponent<Button>();
        Resume = Resume.GetComponent<Button>();
        MainMenu = MainMenu.GetComponent<Button>();
        Exit = Exit.GetComponent<Button>();
        PauseMenu.enabled = false;
	}
	
	// Update is called once per frame
	void Update ()
    {
        if(Input.GetKeyDown("p"))
        {
            OpenPauseMenu();
        }
        if(Input.GetKeyDown("m"))
        {
            OpenMainMenu();
        }
        if(Input.GetKeyDown("r"))
        {
            ResumeGame();
        }
        if(Input.GetKeyDown("q"))
        {
            ExitGame();
        }
    }
    public void OpenPauseMenu()
    {
        PauseMenu.enabled = true;
		if(PauseMenu.enabled == true)
		{
        	GameObject.Find("Player").GetComponent<CharacterController>().enabled = false;
		}
    }
    public void OpenMainMenu()
    {
        Application.LoadLevel(0);
    }
    public void ResumeGame()
    {
        PauseMenu.enabled = false;
        GameObject.FindGameObjectWithTag("Player").GetComponent<CharacterController>().enabled = true;
    }
	public void ExitGame()
    {
        Application.Quit();
    }
}
