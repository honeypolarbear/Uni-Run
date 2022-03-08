using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController2 : MonoBehaviour
{
    public AudioClip deathClip;
    public float jumpForce = 700f;
    
    private int jumpCount = 0;
    private bool isGrounded = false;
    private bool isDead = false;
    private Rigidbody2D playerrigidbody;
    private Animator animator;
    private AudioSource playerAudio;


    // Start is called before the first frame update
    void Start()
    {
        playerrigidbody = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        playerAudio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isDead)
        {
            return;
        }
        if (Input.GetMouseButtonDown(0) && jumpCount<2)
        {

            jumpCount++;

            playerrigidbody.velocity = Vector2.zero;

            playerrigidbody.AddForce(new Vector2(0, jumpForce));

            playerAudio.Play();
        }

        else if (Input.GetMouseButtonUp(0) && playerrigidbody.velocity.y > 0)
        {
            playerrigidbody.velocity = playerrigidbody.velocity * 0.5f;
        }

        animator.SetBool("Grounded", isGrounded);
    }
    private void Die()
    {
        animator.SetTrigger("Die");


        playerAudio.clip = deathClip;

        playerAudio.Play();

        playerrigidbody.velocity = Vector2.zero;

        isDead = true;

        GameManager2.instance.OnPlayerDead();
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Dead" && isDead)
        {
            Die();
        }
    }
    //private void OnCollisionEnter2D(Collision collision)
    //{
    //    if (collision.contacts[0].normal.y> 0.7f)
    //    {
    //        isGrounded = true;
    //        jumpCount = 0;
    //    }
    //}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.contacts[0].normal.y > 0.7f)
        {
            isGrounded = true;
            jumpCount = 0;
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        isGrounded = false;
    }


}
