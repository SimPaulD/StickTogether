using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameOver gOver;
    public GameObject pauseMenuPanel;
    public GameObject settingsMenuPanel;
    public bool GameIsPaused = false;
    public bool SettingIsOn = false;
    void Start()
    {
        pauseMenuPanel.SetActive(false);
        settingsMenuPanel.SetActive(false);
    }

    void Update()
    {
       if(Input.GetKeyDown(KeyCode.Escape)) 
       {
            if(GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
       } 
    }

    public void SettingsOn()
    {
        SettingIsOn = true;
        settingsMenuPanel.SetActive(true);  
    }

    public void SettingsOff()
    {
        SettingIsOn = false;
        settingsMenuPanel.SetActive(false);
    }

    void Resume()
    {
        if(gOver.GameIsOver == false)
        {
                pauseMenuPanel.SetActive(false);
                Time.timeScale = 1f;
                GameIsPaused = false;
        }
        else
        {
            Debug.Log("You can't resume on GameIsOver");
        }
    }
        

    void Pause()
    {
        if(gOver.GameIsOver == false)
        {
            pauseMenuPanel.SetActive(true);
            Time.timeScale = 0f;
            GameIsPaused = true;
        }
        else
        {
            Debug.Log("You cannot pause on GameIsOver");
        }
    }
    


    public void Menu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Menu");
    }

    public void Levels()
    {
         Time.timeScale = 1f;
         SceneManager.LoadScene("ChapterSelector");
    }

    public void Quit(){
        Time.timeScale = 1f;
        Application.Quit();
    }
}
