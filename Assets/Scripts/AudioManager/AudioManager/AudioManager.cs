using UnityEngine.Audio;
using System;
using UnityEngine;
using UnityEngine.SceneManagement;


public class AudioManager : MonoBehaviour
{
    [SerializeField] private AudioMixerGroup masterMixerGroup;
    //[SerializeField] private AudioMixerGroup menuMusicMixerGroup;
    [SerializeField] private AudioMixerGroup soundEffectMixerGroup;
    [SerializeField] private AudioMixerGroup musicMixerGroup;
    [SerializeField] private AudioMixerGroup ambientalMixerGroup;

    public int music;

    public int ambientalSoundId;

    public string currentPlay;

    public string currentAmbientalPlay;

    public Sound[] sounds;

    public static AudioManager instance;

    

    void Start()
    {
        DontDestroyOnLoad(gameObject);
        currentPlay = "Theme";
        currentAmbientalPlay = "Rain";
        Play(currentPlay);
        Play(currentAmbientalPlay);
        music = 0;
        ambientalSoundId = 0;

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

                /* case Sound.AudioTypes.menuMusic:
                    s.source.outputAudioMixerGroup = menuMusicMixerGroup;
                    break; */

                case Sound.AudioTypes.music:
                    s.source.outputAudioMixerGroup = musicMixerGroup;
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
        //menuMusicMixerGroup.audioMixer.SetFloat("menuMusic", Mathf.Log10(AudioOptionManager.menuMusicVolume) * 20);
        soundEffectMixerGroup.audioMixer.SetFloat("soundEffects", Mathf.Log10(AudioOptionManager.soundEffectVolume) * 20);
        ambientalMixerGroup.audioMixer.SetFloat("ambiental", Mathf.Log10(AudioOptionManager.ambientalVolume) * 20);
        musicMixerGroup.audioMixer.SetFloat("music", Mathf.Log10(AudioOptionManager.musicVolume) * 20);
        masterMixerGroup.audioMixer.SetFloat("master", Mathf.Log10(AudioOptionManager.masterVolume) * 20);
    }

}
