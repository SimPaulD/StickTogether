using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelSave : MonoBehaviour
{
    [SerializeField] int levelIndex;
    void Start()
    {
        if(PlayerPrefs.GetInt("Levels")<levelIndex)
            PlayerPrefs.SetInt("Levels", levelIndex);
    }
}
