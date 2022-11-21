using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ObstacleScript : MonoBehaviour
{
    public GameOver gOver;
    public Rigidbody2D rb2d;
    void OnTriggerEnter2D(Collider2D collide) {

            if(collide.gameObject.CompareTag("Player1") || collide.gameObject.CompareTag("Player2"))
            {
               Time.timeScale = 0f;
               
               gOver.gameOverPanel.SetActive(true);
               gOver.GameIsOver = true;
            }
        }
}
