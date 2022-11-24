using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorsMenu : MonoBehaviour
{
    public PlayerInteraction playerInteraction;
    public string sceneName;
    public bool p2Trigger,quit,continueLev;
    public Animator animator;
    public void Start()
    {
        p2Trigger = false;
    }

    void Update()
    {
        if (p2Trigger == true && playerInteraction.use == true)
        {
            if (quit)
            {
                StartCoroutine(waitForQuit());
            }
            else if (continueLev && PlayerPrefs.GetInt("Levels")>0)
            {
                SceneManager.LoadScene("Level" + PlayerPrefs.GetInt("Levels"));
            }
            else
            {
                StartCoroutine(waitForNextLevel());
            }

        }
    }

   
    public void OnTriggerExit2D(Collider2D trigger)
    {
        if (trigger.CompareTag("Player2"))
        {
            p2Trigger = false;
        }
    }
    public void OnTriggerEnter2D(Collider2D trigger)
    {
        if (trigger.CompareTag("Player2"))
        {
            p2Trigger = true;
        }
    }

    public void LoadNextLevel()
    {
        SceneManager.LoadScene(sceneName);
    }

    IEnumerator waitForNextLevel()
        { 
                animator.Play("door_trans_close");
                yield return new WaitForSeconds(2f);
                LoadNextLevel();
        }
    IEnumerator waitForQuit()
        { 
                animator.Play("door_trans_close");
                yield return new WaitForSeconds(2f);
                Debug.Log("Exit");
                Application.Quit();
        }    
}
