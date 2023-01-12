using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundPlayer : MonoBehaviour
{
   
   public string Name;
   
   

   
    void Start()
    {
        FindObjectOfType<AudioManager>().Play(Name);
    }
}
