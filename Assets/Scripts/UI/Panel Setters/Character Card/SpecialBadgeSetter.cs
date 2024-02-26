using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SpecialBadgeSetter : MonoBehaviour
{
    public TextMeshProUGUI text_Timer;
    public float time_In_Seconds=100; 
    private void Start()
    {
        SetBadge(); 
    }
    void SetBadge() {
        StartCoroutine(countdownCoroutine()); 
    }
    IEnumerator countdownCoroutine() {

        yield return new WaitForSeconds(1);
        if (time_In_Seconds >= 0)
        {
            text_Timer.text = formatTime(time_In_Seconds);
            time_In_Seconds--;
        }
             StartCoroutine(countdownCoroutine());
    }

    public string formatTime(float seconds) {
        TimeSpan t = TimeSpan.FromSeconds(seconds);
        string formattedTime = "";
        formattedTime = string.Format("{0:D2}:{1:D2}",
                        t.Minutes,
                        t.Seconds
                       );

        return formattedTime;  
    }
}
