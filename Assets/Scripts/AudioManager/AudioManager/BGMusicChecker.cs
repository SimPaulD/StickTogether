using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BGMusicChecker : MonoBehaviour
{
    [SerializeField] int music;
    [SerializeField] int ambientalSoundId;
    [SerializeField] string ambientalName;
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

        if(audManager.ambientalSoundId!=ambientalSoundId)
        {
            audManager.ambientalSoundId = ambientalSoundId;
            audManager.Stop(audManager.currentAmbientalPlay);
            audManager.Play(ambientalName);
            audManager.currentAmbientalPlay = ambientalName;
        }
        
    }
}
