using UnityEngine.Audio;
using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AudioManager : MonoBehaviour
{
    [SerializeField] private AudioMixerGroup masterMixerGroup;
    [SerializeField] private AudioMixerGroup menuMusicMixerGroup;
    [SerializeField] private AudioMixerGroup soundEffectMixerGroup;
    [SerializeField] private AudioMixerGroup inGameMusicMixerGroup;
    [SerializeField] private AudioMixerGroup ambientalMixerGroup;

    public int music;

    public string currentPlay;

    public Sound[] sounds;

    public static AudioManager instance;

    

    void Start()
    {
        DontDestroyOnLoad(gameObject);
        currentPlay = "Theme";
        Play(currentPlay);
        music = 0;
    }


    void Awake()
    {
        if (instance == null)
            instance = this;
        else
        {
            Destroy(gameObject);
            return;
        }

        
        
        foreach (Sound s in sounds)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;

            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
            s.source.loop = s.loop;

            switch (s.audioType)
            {
                case Sound.AudioTypes.soundEffect:
                    s.source.outputAudioMixerGroup = soundEffectMixerGroup;
                    break;

                case Sound.AudioTypes.menuMusic:
                    s.source.outputAudioMixerGroup = menuMusicMixerGroup;
                    break;

                case Sound.AudioTypes.inGameMusic:
                    s.source.outputAudioMixerGroup = inGameMusicMixerGroup;
                    break;

                case Sound.AudioTypes.ambiental:
                    s.source.outputAudioMixerGroup = ambientalMixerGroup;
                    break;                        
            }

        }
    }
    
    public void Play (string name)
    {
       Sound s = Array.Find(sounds, sound => sound.name == name);
       if(s == null)
       {
            Debug.LogWarning("AudioManager: Couldn't find sound " + name);
            return;
       }
        s.source.Play();
    }

    public void Stop (string sound)
    {
        Sound s = Array.Find(sounds, item => item.name == sound);
        if (s == null)
    {
        Debug.LogWarning("Sound: " + name + " not found!");
        return;
    }

        //s.source.volume = s.volume * (1f + UnityEngine.Random.Range(-s.volume/ 2f, s.volume / 2f));
       // s.source.pitch = s.pitch * (1f + UnityEngine.Random.Range(-s.pitch / 2f, s.pitch / 2f));

        s.source.Stop ();
    }

    public void UpdateMixerVolume()
    {
        menuMusicMixerGroup.audioMixer.SetFloat("MenuMusic", Mathf.Log10(AudioOptionManager.menuMusicVolume) * 40);
        soundEffectMixerGroup.audioMixer.SetFloat("SoundEffects", Mathf.Log10(AudioOptionManager.soundEffectVolume) * 40);
        ambientalMixerGroup.audioMixer.SetFloat("Ambiental", Mathf.Log10(AudioOptionManager.ambientalVolume) * 40);
        inGameMusicMixerGroup.audioMixer.SetFloat("InGameMusic", Mathf.Log10(AudioOptionManager.inGameMusicVolume) * 40);
        masterMixerGroup.audioMixer.SetFloat("Master", Mathf.Log10(AudioOptionManager.masterVolume) * 40);
    }

}
