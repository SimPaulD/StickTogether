using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorsInfo : MonoBehaviour
{
    public GameObject doorInfo;
    public GameObject defaultInfo;

    public void Start() 
    {
        doorInfo.SetActive(false);
        defaultInfo.SetActive(true);
    }

    public void OnTriggerEnter2D(Collider2D col) 
    {
        if(col.CompareTag("Player2"))
        {
            defaultInfo.SetActive(false);
            doorInfo.SetActive(true);
        }
    }

    public void OnTriggerExit2D(Collider2D col) 
    {
        if(col.CompareTag("Player2"))
        {
            defaultInfo.SetActive(true);
            doorInfo.SetActive(false);
        }
    }
}





