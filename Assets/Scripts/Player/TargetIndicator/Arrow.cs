using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    public SpikeLaunch spikeL;

    private void OnTriggerEnter2D(Collider2D col) 
    {
        if(col.gameObject.CompareTag("Ground"))
        {   
            spikeL.hasHit = true;
            spikeL.rb2d.velocity = Vector2.zero;
            spikeL.rb2d.isKinematic = true;    
        }
    }
}
