using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class barralMovement : MonoBehaviour
{
    HingeJoint2D joint;
    public float speed;
    public float elevation;
    //public Rigidbody2D rb;

    
    // Start is called before the first frame update
    void Start()
    {
        joint = GetComponent<HingeJoint2D>();
      //  rb.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        JointMotor2D motor;
        motor = joint.motor; 
        motor.motorSpeed = speed;
        if (Input.GetKey("w"))
        {
           
            if (elevation > -4)
            {
                speed = 40;
               
                joint.motor = motor;
                elevation -= 0.5f;
            }
            
        }
        if (Input.GetKey("s"))
        {
           if(elevation < 3) 
            {  
                speed = -40;
               
                joint.motor = motor;
                elevation += 0.5f;
            }
        }
 
        else 
        {
            speed = 0;
           
            joint.motor = motor;
        }
        
    }
}
