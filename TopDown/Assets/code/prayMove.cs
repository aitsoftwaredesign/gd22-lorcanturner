﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class prayMove : MonoBehaviour
{
    float speed = 10;
    float turnSpeed = 400;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        moveForward();
        turn();
    }

    void moveForward()
    {
        if(Input.GetKey("w"))
        {
            transform.Translate(0, speed * Time.deltaTime, 0);
        }
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
