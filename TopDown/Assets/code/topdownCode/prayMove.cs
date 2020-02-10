using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class prayMove : MonoBehaviour
{
    public float speed = 10;
    public float turnSpeed = 400;
    Rigidbody2D rb;

    private Vector3 lastPosition;
   
    // Start is called before the first frame update
    void Start()
    {
       // lastPosition = transform.position;
        //Vector3 velocity = 
    }

    // Update is called once per frame
    void Update()
    {
        moveForward();
        turn();
        //Debug.DrawRay()
    }

    void moveForward()
    {
        if (Input.GetKey("w"))
        {
           transform.Translate(0, speed * Time.deltaTime, 0);
        }

     //   Vector3 velocity = lastPosition - transform.position;
       

    }

    void turn()
    {
        if(Input.GetKey("d"))
        {
            transform.Rotate(-Vector3.forward * turnSpeed * Time.deltaTime);
        }

        if (Input.GetKey("a"))
        {
            transform.Rotate(Vector3.forward * turnSpeed * Time.deltaTime);
        }
    }
}
