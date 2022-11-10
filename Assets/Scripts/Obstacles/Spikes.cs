using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Spikes : MonoBehaviour
{
    public GameOver gOver;
    //public GameObject player;
    public Rigidbody2D rb2d;
   //public float gravity;
   //public float minDistance;

    /*public void Update()
    {
        float dist = Vector2.Distance(this.gameObject.transform.position, player.transform.position);

        if(dist < minDistance)
        {
            Debug.Log("merge");
            rb2d.gravityScale = gravity;

        }
    }*/

    void OnTriggerEnter2D(Collider2D collide) {

            if(collide.gameObject.CompareTag("Player1") || collide.gameObject.CompareTag("Player2"))
            {
               Time.timeScale = 0f;
               FindObjectOfType<AudioManager>().Play("Dead");
               gOver.gameOverPanel.SetActive(true);
               gOver.GameIsOver = true;
            }
        }
}
