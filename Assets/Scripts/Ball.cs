using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed = 5f;
    public Vector2 iniPos = new Vector2(0, 0);
    public AudioSource hit;
    public float max = 100;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        
        
    }
    private void Update()
    {

        //Debug.Log(rb.velocity.magnitude);
        if (rb.velocity.magnitude > max)
        {
            rb.velocity = rb.velocity.normalized * max;
           
        }
    }



    void RandomizeTrajectory()
    {
        Vector2 force;
        force.x = Random.Range(-2, 2);
        force.y = 0;
        rb.AddForce(force*speed);

    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Respawn"))
        {   
            AudioSource audioSource = GetComponent<AudioSource>();
            audioSource.Play();
            gameObject.transform.position = iniPos;
            rb.velocity = Vector2.zero;
            RandomizeTrajectory();
        }
        if (collision.gameObject.CompareTag("Paddle"))
        {   
           

            hit.Play(); 
        }
    }
    
}
