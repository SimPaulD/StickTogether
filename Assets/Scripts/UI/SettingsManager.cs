using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SettingsManager : MonoBehaviour
{
    [SerializeField] Toggle vSync;
    int rez;
    [SerializeField] TextMeshProUGUI resolutionText;
    // Start is called before the first frame update
    void Start()
    {
        //Screen resolution
        Screen.SetResolution(Screen.currentResolution.width, Screen.currentResolution.height, true);
        resolutionText.text = Screen.currentResolution.width + "x" + Screen.currentResolution.height;
        if (Screen.currentResolution.width == 1280 && Screen.currentResolution.height == 720)
            rez = 1;
        else if (Screen.currentResolution.width == 1280 && Screen.currentResolution.height == 800)
            rez = 2;
        else if (Screen.currentResolution.width == 1600 && Screen.currentResolution.height == 900)
            rez = 3;
        else if (Screen.currentResolution.width == 1440 && Screen.currentResolution.height == 900)
            rez = 4;
        else if (Screen.currentResolution.width == 1920 && Screen.currentResolution.height == 1080)
            rez = 5;
        else if (Screen.currentResolution.width == 1920 && Screen.currentResolution.height == 1200)
            rez = 6;
        else if (Screen.currentResolution.width == 2560 && Screen.currentResolution.height == 1440)
            rez = 7;
        else if (Screen.currentResolution.width == 2560 && Screen.currentResolution.height == 1600)
            rez = 8;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void LeftResolution()
    {
        if (rez == 1)
            rez = 8;
        else
            rez--;
        CheckRez();
    }
    public void RightResolution()
    {
        if (rez == 8)
            rez = 1;
        else
            rez++;
        CheckRez();
    }
    void CheckRez()
    {
        if(rez==1)
        {
            resolutionText.text = "1280x720";
            Screen.SetResolution(1280, 720, true);
            
        }
        else if(rez==2)
        {
            resolutionText.text = "1280x800";
            Screen.SetResolution(1280, 800, true);
        }
        else if (rez == 3)
        {
            resolutionText.text = "1600x900";
            Screen.SetResolution(1600, 900, true);
        }
        else if(rez==4)
        {
            resolutionText.text = "1440x900";
            Screen.SetResolution(1600, 900, true);
        }
        else if (rez == 5)
        {
            resolutionText.text = "1920x1080";
            Screen.SetResolution(1920, 1080, true);
        }
        else if (rez == 6)
        {
            resolutionText.text = "1920x1200";
            Screen.SetResolution(1920, 1200, true);
        }
        else if (rez == 7)
        {
            resolutionText.text = "2560x1440";
            Screen.SetResolution(2560, 1440, true);
        }
        else if (rez == 8)
        {
            resolutionText.text = "2560x1600";
            Screen.SetResolution(2560, 1600, true);
        }
    }
    public void Vsync()
    {
        if (vSync.isOn)
            QualitySettings.vSyncCount = 1;
        else
            QualitySettings.vSyncCount = 0;
    }
    
}
