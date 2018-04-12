﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer_Stage4 : MonoBehaviour {

    public Text timer;
    float timeLeft = 240.0f;
    //public Text timealmostup;
    // Use this for initialization
    void Start()
    {
        timer.text = "Time Left: " + timeLeft.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        timeLeft -= Time.deltaTime;

        timer.text = "Time Left: " + Mathf.Round(timeLeft).ToString();
        /*if (timeLeft <= 20)
        {
            timealmostup.text = "TIME ALMOST UP!!!!";
        }*/
        if (timeLeft <= 0)
        {
            Application.LoadLevel(8);
        }

    }

}
