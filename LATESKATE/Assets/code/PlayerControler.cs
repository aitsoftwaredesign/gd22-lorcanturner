using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerControler : MonoBehaviour
{


    BoxCollider2D collider;
    
    Animator animator;
    Rigidbody2D rb2d;
    SpriteRenderer spriteRenderer;
    float constSpeed = 15;

    bool isGrounded;

    [SerializeField]//make available in unity editor
    Transform groundCheck;
    
    // Start is called before the first frame update
    void Start()
    {



        animator = GetComponent<Animator>();
        rb2d = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();

       
    }
    private void FixedUpdate()
    {


        
        if (Physics2D.Linecast(transform.position, groundCheck.position, 1 << LayerMask.NameToLayer("Ground")))
        {
            isGrounded = true;
          
        }
        else
        {
            isGrounded = false;

        }

        if (Input.GetKey("d") || Input.GetKey("right") || Input.GetKeyUp("d")||Input.GetKeyUp("right") )
        {

           rb2d.velocity = new Vector2 (15,rb2d.velocity.y);
            if(isGrounded )
            {
             animator.Play("Skating");
               
            }
          
        }
     
        
        if(Input.GetKeyDown("space") && isGrounded == true || Input.GetKeyDown("w") && isGrounded == true)
        {

            rb2d.velocity = new Vector2(rb2d.velocity.x,12);
            if(isGrounded )
            {
            animator.Play("jump");

            }
          
        }
        if(Input.GetKeyDown("s") && isGrounded == true)
        {
            animator.Play("limbo");
           

        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
