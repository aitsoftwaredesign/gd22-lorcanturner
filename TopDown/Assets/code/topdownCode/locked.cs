﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class locked : MonoBehaviour
{
    bool doorLocked = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(doorLocked == false)
        {
            gameObject.GetComponent<Rigidbody2D>().mass = 14;
        }
        else
        {
            gameObject.GetComponent<Rigidbody2D>().mass = 1000000;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player") && PrayCollisions.hasKey == true)
        {
            doorLocked = false;
            PrayCollisions.hasKey = false;
        }

            
    }
}