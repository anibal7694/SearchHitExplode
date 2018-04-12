using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Start_Menu : MonoBehaviour {

    public Canvas QuitMenu;
    public Button StartGame;
    public Button Instruction;
    public Button ExitGame;
    public Button ExitYes;
    public Button ExitNo;
	// Use this for initialization
	void Start () {
        QuitMenu = QuitMenu.GetComponent<Canvas>();
        StartGame = StartGame.GetComponent<Button>();
        Instruction = Instruction.GetComponent<Button>();
        ExitGame = ExitGame.GetComponent<Button>();
        QuitMenu.enabled = false;
    }

    // Update is called once per frame
    void Update () {
        if (Input.GetKeyDown("s"))
            GameStart();
        if (Input.GetKeyDown("i"))
            Instructions();
        if (Input.GetKeyDown("q"))
            ExitPress();
        if (Input.GetKeyDown("y"))
            FullyQuit();
        if (Input.GetKeyDown("n"))
            NoPress();
	}
    public void GameStart()
    {
        Application.LoadLevel(1);
    }
    public void Instructions()
    {
        Application.LoadLevel(7);
    }
    public void ExitPress()
    {
        QuitMenu.enabled = true;
        StartGame.enabled = false;
        Instruction.enabled = false;
        ExitGame.enabled = false;
    }
    public void NoPress()
    {
        QuitMenu.enabled = false;
        StartGame.enabled = true;
        Instruction.enabled = true;
        ExitGame.enabled = true;
    }
    public void FullyQuit()
    {
        Application.Quit();
    }
}
