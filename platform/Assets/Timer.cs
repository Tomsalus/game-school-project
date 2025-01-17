﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{

    public Text TimerText;
    private float startTime;
    private bool finished = false;

    // Start is called before the first frame update
    void Start()
    {
        startTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if (finished)
            return;

        float t = Time.time - startTime;

        string minutes = ((int)t / 60).ToString();
        string seconds = (t % 60).ToString("f2");

        TimerText.text = minutes + ":" + seconds;
    }


    public void Finish()
    {
        finished = true;
        TimerText.color = Color.red;
    }
}
