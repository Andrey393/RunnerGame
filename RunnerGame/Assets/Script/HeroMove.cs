using System.Collections;
using System.Collections.Generic;
using UnityEditor.Timeline;
using UnityEngine;

public class HeroMove : MonoBehaviour
{
    private Rigidbody2D rg2d;

    private float moveSpeed;
    private float jumpForce;
    private bool isJumping;

    private float moveHorizonal;
    private float moveVertinal;

    private void Start() 
    {
        rg2d =gameObject.GetComponent<Rigidbody2D>();

        moveSpeed = 0.5f;
        jumpForce = 10f;
        isJumping = false;
    }

    void Update()
    {
        moveHorizonal = Input.GetAxisRaw("Horizontal");
        moveVertinal = Input.GetAxisRaw("Vertical");
    }

    private void FixedUpdate() 
    {
        if (moveHorizonal >0.1f || moveHorizonal< -0.1f) 
        {
            rg2d.AddForce(new Vector2(moveHorizonal * moveSpeed, 0f),ForceMode2D.Impulse);
        }
        if (!isJumping && moveVertinal > 0.1f) 
        {
            rg2d.AddForce(new Vector2(0f, moveVertinal * jumpForce), ForceMode2D.Impulse);
        }

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if(collision.gameObject.tag == "Platform") 
        {
            isJumping = false;
        }

        //if (collision.gameObject.tag == "GameOver") //Происходить, когда сталкивается с опасным препяствием 
        //{
        //    Debug.Log("Конец игры");
        //}

      

    }
    private void OnTriggerExit2D(Collider2D collision) 
    {
        if (collision.gameObject.tag == "Platform")
        {
            isJumping = true;
        }
    }
    
}
