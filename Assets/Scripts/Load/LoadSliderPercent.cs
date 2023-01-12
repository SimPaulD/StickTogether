using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadSliderPercent : MonoBehaviour
{
    public AudioOptionManager load;
    public AudioManager audManager;


    void Start()
    {
        audManager = GameObject.FindGameObjectWithTag("audio").GetComponent<AudioManager>();
        load = GameObject.FindGameObjectWithTag("audio").GetComponent<AudioOptionManager>();
        load.LoadSliders();
    }
}
