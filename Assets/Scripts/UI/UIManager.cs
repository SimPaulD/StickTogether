using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public void MainMenu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Menu");
    }
    public void ExitGame()
    {
        Application.Quit();
    }
}
