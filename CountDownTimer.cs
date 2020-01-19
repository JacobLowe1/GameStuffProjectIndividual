using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDownTimer : MonoBehaviour
{
    int countDownStartValue = 12;
    public Text timerUI;
    // Start is called before the first frame update
    void Start()
    {
        countDownTimer();
    }

    void countDownTimer ()
    {
        if (countDownStartValue > 0)
        {
            TimeSpan spanTime = TimeSpan.FromSeconds(countDownStartValue);
            timerUI.text = "Timer : " + spanTime.Minutes + ":" + spanTime.Seconds;
            countDownStartValue--;
            Invoke("countDownTimer", 1.0f);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
