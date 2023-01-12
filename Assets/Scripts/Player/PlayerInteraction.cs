using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerInteraction : MonoBehaviour
{
    public bool use = false;

    void Update()
    {
       Restart();
       Use();
    }

    public void Restart()
    {
        if(Input.GetKeyDown(KeyCode.R) && SceneManager.GetActiveScene().buildIndex != 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            Time.timeScale = 1;
        }
    }

     public void Use()
    {
        if(Input.GetButtonDown("Interact"))
        {
            use = true;
        }

        if(Input.GetButtonUp("Interact"))
        {
            use = false;
        }
    }
}
