using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowInfo : MonoBehaviour
{
    public GameObject spaceKey;
    public Animator door1;
    public Animator door2;

    private void Start()
    {
       spaceKey.SetActive(false);
    }
    
    private void OnTriggerEnter2D(Collider2D other) {

        if(other.gameObject.CompareTag("Player1") || other.gameObject.CompareTag("Player2"))
        {
            spaceKey.SetActive(true);
            StartCoroutine(waitForAnimation());
        }

    }

    private void OnTriggerExit2D(Collider2D other) {

        if(other.gameObject.CompareTag("Player1") || other.gameObject.CompareTag("Player2"))
        {
            door1.Play("FadeOut");
            door2.Play("FadeOut");
            //spaceKey.SetActive(false);
        }

    }

    IEnumerator waitForAnimation()
        { 
                door1.Play("FadeIn");
                door2.Play("FadeIn");
                yield return new WaitForSeconds(0.4f);
                door1.Play("Float");
                door2.Play("Float");
        }    


}
