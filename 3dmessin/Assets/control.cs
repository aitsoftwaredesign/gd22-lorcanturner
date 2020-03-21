using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class control : MonoBehaviour
{
    
    public float speed = 0.5f;
    public float xMove = 0;
    public float yMove = 0;
    public float zMove = 0;
    public Rigidbody rb;

    public float timer;
    // Start is called before the first frame update
    void Start()
    {
        rb.GetComponent<Rigidbody>();
    
    }

    // Update is called once per frame
    void Update()
    {

        timer += Time.deltaTime;
        float deltaSpeed = speed * Time.deltaTime;
        controlCheck();
       


    }

    public void controlCheck()
    {
        // Debug.Log(timer);
        if (Input.GetKey("space"))
        {
            yMove = speed;
            rb.useGravity = false;
        }
        else
        {
            yMove = 0;
            rb.useGravity = true;
        }


        if (Input.GetKey("a"))
        {
            xMove = -speed;
        }
        if (Input.GetKey("d"))
        {
            xMove = speed;
        }
        if (Input.GetKeyUp("a"))
        {
            xMove = 0;
        }
        if (Input.GetKeyUp("d"))
        {
            xMove = 0;
        }



        if (Input.GetKey("s"))
        {
            zMove = -speed;

        }
        if (Input.GetKey("w"))
        {
            zMove = speed;
        }
        if (Input.GetKeyUp("w"))
        {
            zMove = 0;
        }
        if (Input.GetKeyUp("s"))
        {
            zMove = 0;
        }

        transform.Translate(xMove, yMove, zMove);

    }


}
