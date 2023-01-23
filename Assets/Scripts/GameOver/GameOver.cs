using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public GameObject gameOverPanel;
    public bool GameIsOver;
    public Animator animPanel;

    void Start()
    {
        gameOverPanel.SetActive(false);
        GameIsOver = false;
    }
    void Update()
    {
      StartCoroutine(animWait()); 
    }

    IEnumerator animWait()
    {
        if(GameIsOver == true)
        {
            //Debug.Log("Hatz");
            animPanel.Play("ShakeRestart");
            yield return new WaitForSeconds(1f);
            animPanel.Play("FloatInPanel");
             
            
        }
    }

   
}
