using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutOffScreen : MonoBehaviour {
   
    public TargetIndicator _target;

     void OnBecameInvisible()
    {   
        _target.outScreen = true;
        _target.onScreen = false;
    }

    void OnBecameVisible()
    {   
        _target.onScreen = true;
        _target.outScreen = false;
    }
}