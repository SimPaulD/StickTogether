using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeLaunch : MonoBehaviour
{
    public Rigidbody2D rb2d;
    public bool hasHit;
    [SerializeField] private bool triggerOn;
    public float speedX = 5f;
    public float speedY = 0f;

    void Start()
    {
        rb2d.velocity = Vector2.zero;
        rb2d.isKinematic = false;
        triggerOn = false;
        hasHit = false;
    }

    void Update()
    {
        if(triggerOn == true && hasHit == false)
        {
            Shoot();
        }

    }


    public void Shoot()
    {
        rb2d.AddForce(new Vector2(speedX, speedY));
    }

   
    private void OnTriggerEnter2D(Collider2D col) 
    {
        if(col.gameObject.CompareTag("Player1") || col.gameObject.CompareTag("Player2"))
        {
              triggerOn = true;
        }
    }

     private void OnTriggerExit2D(Collider2D col) 
    {
        if(col.gameObject.CompareTag("Player1") || col.gameObject.CompareTag("Player2"))
        {
              triggerOn = false;
        }
    }
    /* private void OnTriggerExit2D(Collider2D other) 
    {
        triggerOn = false;    
    } */
}    
