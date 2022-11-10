using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    public TextMeshProUGUI timerText;
    float timer;
    void Update()
    {
        timer += Time.deltaTime;
        
        if(timer>59)
            timerText.text = (int)timer/60+"."+(timer % 60).ToString("00.0");
        else
            timerText.text = (timer % 60).ToString("F1");
    }
}
