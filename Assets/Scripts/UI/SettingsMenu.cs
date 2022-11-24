using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingsMenu : MonoBehaviour
{
    public GameObject settingPanel;
    public bool settingIsOn;

   
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape) && settingIsOn == false)
        {
            SettingIsOn();
        }

        if(Input.GetKeyDown(KeyCode.Escape) && settingIsOn == true)
        {
            SettingIsOff();
        }
    }

    public void SettingIsOn()
    {
        settingIsOn = true;
        settingPanel.SetActive(true);
        Time.timeScale = 0f;
    }

    public void SettingIsOff()
    {
        settingIsOn = false;
        settingPanel.SetActive(false);
        Time.timeScale = 1f;
    }
}
