using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeathSounds : MonoBehaviour
{
        public GameObject[] objects;

    private void OnTriggerEnter(Collider col) 
    {
        if(col.gameObject == objects[0] )
        {
            FindObjectOfType<AudioManager>().Play("Wrong");
        }

        if(col.gameObject == objects[1] )
        {
            FindObjectOfType<AudioManager>().Play("Death");
        }
    }
}
