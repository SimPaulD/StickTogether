using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Doors : MonoBehaviour
{
    public PlayerInteraction playerInteraction;

    public string sceneName;
    public bool p1Trigger;
    public bool p2Trigger;
    public Animator animator;

    public void Start()
    {
        p1Trigger = false;
        p2Trigger = false;
    }
   
        void Update()
        {
                if(p1Trigger == true && p2Trigger == true &&playerInteraction.use == true)
                        {
                               StartCoroutine(trans());
                        }
                        else if(p1Trigger == true && p2Trigger == false && playerInteraction.use == true)
                        {
                                StartCoroutine(audioWait());
                        }
                        else if(p1Trigger == false && p2Trigger == true && playerInteraction.use == true)
                        {
                                StartCoroutine(audioWait());                                
                        }
        }

        public void OnTriggerExit2D(Collider2D trigger)
        {
               if(trigger.CompareTag("Player1")) 
                {
                        p1Trigger = false;
                }

                if(trigger.CompareTag("Player2")) 
                {
                        p2Trigger = false;
                } 
        }
        public void OnTriggerEnter2D(Collider2D trigger)
        {
                if(trigger.CompareTag("Player1")) 
                {
                        p1Trigger = true;
                }

                if(trigger.CompareTag("Player2")) 
                {
                        p2Trigger = true;
                } 
        }

         public void LoadNextLevel()
        {
                SceneManager.LoadScene(sceneName);
        }

        IEnumerator trans()
        {
                animator.Play("door_trans_close");
                yield return new WaitForSeconds(1.5f);
                LoadNextLevel();
        }

        IEnumerator audioWait()
        {
                FindObjectOfType<AudioManager>().Play("Wrong");
                yield return new WaitForSeconds(5f);
                Debug.Log("You need 2 players to open the door");
                
        }
}
