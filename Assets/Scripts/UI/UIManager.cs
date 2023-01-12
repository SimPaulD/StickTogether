using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public Animator animator;

    public void MainMenu()
    {
         Time.timeScale = 1;
        SceneManager.LoadScene("Menu"); 
        //StartCoroutine(waitForNextLevel());
    }
    public void ExitGame()
    {
        Application.Quit();
       // StartCoroutine(waitForQuit());
    }


     IEnumerator waitForNextLevel()
        { 
                animator.Play("door_trans_close");
                yield return new WaitForSeconds(2f);
                SceneManager.LoadScene("Menu");
        }
    IEnumerator waitForQuit()
        { 
                animator.Play("door_trans_close");
                yield return new WaitForSeconds(2f);
                Debug.Log("Exit");
                Application.Quit();
        }    
    
}



/* using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public Animator animator;
    

    public void MainMenu()
    {
         StartCoroutine(waitForNextLevel());
    }
    public void ExitGame()
    {
        StartCoroutine(waitForQuit());
    }

    IEnumerator waitForNextLevel()
        { 
                animator.Play("door_trans_close");
                yield return new WaitForSeconds(2f);
                SceneManager.LoadScene("Menu");
        }
    IEnumerator waitForQuit()
        { 
                animator.Play("door_trans_close");
                yield return new WaitForSeconds(2f);
                Debug.Log("Exit");
                Application.Quit();
        }    

} */

