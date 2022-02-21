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
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void Die()
    {

    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        
    }
    private void OnCollisionEnter2D(Collision collision)
    {

    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        
    }


}
