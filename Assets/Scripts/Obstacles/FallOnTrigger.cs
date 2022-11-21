using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallOnTrigger : MonoBehaviour
{
    public ObstacleScript obstacle;
    public float gravity;
    
    private void OnTriggerEnter2D(Collider2D colide) 
    {
            if(colide.gameObject.CompareTag("Player1") || colide.gameObject.CompareTag("Player2"))
            {
                obstacle.rb2d.gravityScale = gravity;
            }
    }
}
