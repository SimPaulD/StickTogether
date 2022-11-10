using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public GameObject gameOverPanel;
    public bool GameIsOver = false;

    void Start()
    {
        gameOverPanel.SetActive(false);
    }
    void Update()
    {
       //Restart();
    }

    /* public void Restart()
    {
         if(GameIsOver == true && Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            Time.timeScale = 1;
        }
    } */
}
