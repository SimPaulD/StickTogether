using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunInBackground : MonoBehaviour
{
    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }
}
