using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AudioOptionManager : MonoBehaviour
{
    public static float masterVolume {get; private set; }
    public static float menuMusicVolume {get; private set; }
    public static float soundEffectVolume {get; private set; }
    public static float inGameMusicVolume {get; private set; }
    public static float ambientalVolume {get; private set; }

    [SerializeField] private TextMeshProUGUI masterSliderText;
    [SerializeField] private TextMeshProUGUI menuMusicSliderText;
    [SerializeField] private TextMeshProUGUI soundEffectSliderText;
    [SerializeField] private TextMeshProUGUI ambientalSliderText;
    [SerializeField] private TextMeshProUGUI inGameMusicSliderText;

    public void OnMenuMusicSliderValueChanged(float value)
    {
        menuMusicVolume = value;

        menuMusicSliderText.text = ((int)(value * 100)).ToString();
        Debug.Log(value);
        AudioManager.instance.UpdateMixerVolume();
    }

    public void OnSoundEffectSliderValueChanged(float value)
    {
        soundEffectVolume = value;

        soundEffectSliderText.text = ((int)(value * 100)).ToString();
        AudioManager.instance.UpdateMixerVolume();
    }

    public void OnAmbientalSliderValueChanged(float value)
    {
        ambientalVolume = value;

        ambientalSliderText.text = ((int)(value * 100)).ToString();
        AudioManager.instance.UpdateMixerVolume();
    }
    public void OnInGameMusicSliderValueChanged(float value)
    {
        inGameMusicVolume = value;

        inGameMusicSliderText.text = ((int)(value * 100)).ToString();
        AudioManager.instance.UpdateMixerVolume();
    }

    public void OnMasterSliderValueChanged(float value)
    {
       masterVolume = value;

        masterSliderText.text = ((int)(value * 100)).ToString();
        AudioManager.instance.UpdateMixerVolume();
    }

}
