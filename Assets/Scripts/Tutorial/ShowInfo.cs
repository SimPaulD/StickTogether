using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowInfo : MonoBehaviour
{
    public GameObject spaceKey;

    private void Start()
    {
        spaceKey.SetActive(false);
    }
    
    private void OnTriggerEnter2D(Collider2D other) {

        if(other.gameObject.CompareTag("Player1") || other.gameObject.CompareTag("Player2"))
        {
            spaceKey.SetActive(true);
        }

    }

    private void OnTriggerExit2D(Collider2D other) {

        if(other.gameObject.CompareTag("Player1") || other.gameObject.CompareTag("Player2"))
        {
            spaceKey.SetActive(false);
        }

    }


}
