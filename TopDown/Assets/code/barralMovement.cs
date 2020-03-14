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

        if (Input.GetKey("s") || Input.GetKey("w"))
        {
            if(Input.GetKey("w")&& elevation < 5)
            {
                 speed = +40;
                 joint.motor = motor;
                 elevation += 0.5f;
                motor.motorSpeed = 40;
            }
            if (Input.GetKey("s") && elevation > 2.5)
            {
                speed = -40;
                joint.motor = motor;
                elevation -= 0.5f;
                motor.motorSpeed = -40;
            }

            else
            {
                speed = 0;
                joint.motor = motor;
                elevation = 3;
                motor.motorSpeed = speed;
            }
        }
        else 
        {
            speed = 0;
            joint.motor = motor;
        }
        
    }
}
