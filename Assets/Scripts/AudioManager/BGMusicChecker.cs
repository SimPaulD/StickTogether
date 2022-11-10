using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGMusicChecker : MonoBehaviour
{
    [SerializeField] int music;
    [SerializeField] string musicName;
    public AudioManager audManager;
    void Start()
    {
        audManager = GameObject.FindGameObjectWithTag("audio").GetComponent<AudioManager>();
        if(audManager.music!=music)
        {
            audManager.music = music;
            audManager.Stop(audManager.currentPlay);
            audManager.Play(musicName);
            audManager.currentPlay = musicName;
        }
        
    }
}
