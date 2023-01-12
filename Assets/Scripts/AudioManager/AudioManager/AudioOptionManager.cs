using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Audio;
using UnityEngine.UI;

public class AudioOptionManager : MonoBehaviour
{   
    
    public static float masterVolume {get; private set; }
    public static float soundEffectVolume {get; private set; }
    public static float musicVolume {get; private set; }
    public static float ambientalVolume {get; private set; }
    [Header("Sliders")]
    public Slider masterVolumeSlider;
    public Slider soundEffectVolumeSlider;
    public Slider musicVolumeSlider;
    public Slider ambientalVolumeSlider;


      //[SerializeField] private TextMeshProUGUI masterSliderText;
     //[SerializeField] private TextMeshProUGUI soundEffectSliderText;
    //[SerializeField] private TextMeshProUGUI ambientalSliderText;
   //[SerializeField] private TextMeshProUGUI inGameMusicSliderText;

    void Start()      
    {
        //audioOptionManager = GameObject.FindGameObjectWithTag("MasterVol").GetComponent<AudioOptionManager>();
        //audioOptionManager = GameObject.FindGameObjectWithTag("SfxVol").GetComponent<AudioOptionManager>();
        //audioOptionManager = GameObject.FindGameObjectWithTag("MusicVol").GetComponent<AudioOptionManager>();
        //audioOptionManager = GameObject.FindGameObjectWithTag("AmbientalVol").GetComponent<AudioOptionManager>(); 
    }

    public void OnSoundEffectSliderValueChanged(float value)
    {
        soundEffectVolume = value;
        soundEffectVolumeSlider.value = soundEffectVolume;
        AudioManager.instance.UpdateMixerVolume();
        PlayerPrefs.SetFloat("soundEffectVolume", soundEffectVolume);
        PlayerPrefs.Save();
    }
    public void OnAmbientalSliderValueChanged(float value)
    {
        ambientalVolume = value;
        ambientalVolumeSlider.value = ambientalVolume;
        AudioManager.instance.UpdateMixerVolume();
        PlayerPrefs.SetFloat("ambientalVolume", ambientalVolume);
        PlayerPrefs.Save();
    }
    public void OnMusicSliderValueChanged(float value)
    {
        musicVolume = value;
        musicVolumeSlider.value = musicVolume;
        AudioManager.instance.UpdateMixerVolume();
        PlayerPrefs.SetFloat("musicVolume", musicVolume);
        PlayerPrefs.Save();
    }

    public void OnMasterSliderValueChanged(float value)
    {
        masterVolume = value;
        masterVolumeSlider.value = masterVolume;
        AudioManager.instance.UpdateMixerVolume();
        PlayerPrefs.SetFloat("masterVolume", masterVolume);
        PlayerPrefs.Save();
    }

    public void LoadSliders()
    {
        masterVolume = PlayerPrefs.GetFloat("masterVolume"); 
        soundEffectVolume = PlayerPrefs.GetFloat("soundEffectVolume");
        musicVolume = PlayerPrefs.GetFloat("musicVolume");
        ambientalVolume = PlayerPrefs.GetFloat("ambientalVolume");
        Debug.Log("merge");
    }

}
