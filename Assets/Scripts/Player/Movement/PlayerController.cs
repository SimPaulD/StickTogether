using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speedMovement, jumpForce;
    private Rigidbody2D rb;
    private float Horizontal;
    private CapsuleCollider2D colliders;
    [SerializeField]LayerMask GroundJump;
    void Start()
    {
        colliders = GetComponent<CapsuleCollider2D>();
        rb = GetComponent<Rigidbody2D>();
        if (!PlayerPrefs.HasKey("Levels"))
            PlayerPrefs.SetInt("Levels", 0);
    }

    void Update()
    {
        Horizontal = Input.GetAxis("Horizontal");
        if (Horizontal != 0)
        {
           rb.velocity = new Vector2(speedMovement * Horizontal, rb.velocity.y);
        }
        if (Input.GetButtonDown("Jump") && isGrounded())
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
            FindObjectOfType<AudioManager>().Play("Jump");
        }
    }
    bool isGrounded()
    {
        return Physics2D.BoxCast(colliders.bounds.center, new Vector2(.5f,.3f), 0f, Vector2.down,.5f,GroundJump);
    }
}
