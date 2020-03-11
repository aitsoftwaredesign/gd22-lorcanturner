using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class prayMove : MonoBehaviour
{
    public float speed = 10;
    public float turnSpeed = 400;
    public static float currentSpeed = 0;
    public Transform predition;


    Vector3 direction;
    
   
    // Start is called before the first frame update
    void Start()
    {
        predition.transform.Translate(0, 2, 0);
    }

    // Update is called once per frame
    void Update()
    {
        moveForward();
        turn();
        //Debug.DrawRay()
       velocity();


        
    }

    void moveForward()
    {
        if (Input.GetKey("w"))
        {
            currentSpeed = 10;
           transform.Translate(0, speed * Time.deltaTime, 0);

        }
        else
        {
            currentSpeed = 0;
        }

   

       

    }

    void velocity()
    {
        if(currentSpeed > 5)
        {
          
            //Debug.DrawRay(transform.position, predition.transform.position.normalized * 5 , Color.blue);
        }
        else
        {
            //predition.transform.Translate(0, 0, 0);
           // Debug.DrawRay(transform.position, predition.transform.position.normalized * 2, Color.blue);
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
