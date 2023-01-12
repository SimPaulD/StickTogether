using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
using TMPro;

public class SettingsManager : MonoBehaviour
{
    public AudioMixer audioMixer;

    public TMP_Dropdown resolutionDropdown;

    Resolution[] resolutions;
    public Toggle vsyncTog, fullScreenTog;

    public static SettingsManager instance;

    
    void Awake()
    {
        /* if (instance == null)
            instance = this;
        else
        {
            Destroy(gameObject);
            return;
        } */
    }    

    void Start() 
    {
        //DontDestroyOnLoad(gameObject);

        resolutions = Screen.resolutions;

        resolutionDropdown.ClearOptions();

        List<string> options = new List<string>();

        int currentResolutionIndex = 0;

        for (int i = 0; i < resolutions.Length; i++)
        {
            string option = resolutions[i].width + " x " +  resolutions[i].height;
            options.Add(option);

            if(resolutions[i].width == Screen.currentResolution.width &&
               resolutions[i].height == Screen.currentResolution.height)
            {
                currentResolutionIndex = i;
            }
        }
        
        fullScreenTog.isOn = Screen.fullScreen;

        fullScreenTog.isOn = true;

        if(QualitySettings.vSyncCount == 0)
        {
            vsyncTog.isOn = false;
        }
        else
        {
            vsyncTog.isOn = true;
        }

        resolutionDropdown.AddOptions(options);
        resolutionDropdown.value = currentResolutionIndex;
        resolutionDropdown.RefreshShownValue();
    }

    public void SetResolution(int resolutionIndex)
    {
        Resolution resolution = resolutions[resolutionIndex];
        Screen.SetResolution(resolution.width, resolution.height, Screen.fullScreen);
    }

    public void SetQuality(int qualityIndex)
    {
        QualitySettings.SetQualityLevel(qualityIndex);
    }

    public void ApplyGraphics()
    {
        
        Screen.fullScreen = fullScreenTog.isOn;

        if(vsyncTog.isOn)
        {
            Debug.Log("vSyncIsOn");
            QualitySettings.vSyncCount = 1;
        }
        else
        {
            Debug.Log("vSyncIsOff");
            QualitySettings.vSyncCount = 0;
        }
    }

}
