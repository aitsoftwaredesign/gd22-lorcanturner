using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class barralMovement : MonoBehaviour
{
    HingeJoint2D joint;
    public float speed = 0;
    public float elevation = 0;
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
        if (Input.GetKey("w") && elevation < 20)
        {
            speed = -40;
            motor.motorSpeed = speed;
            joint.motor = motor;
            elevation -= 0.5f;
        }
        if (Input.GetKey("s") && elevation > 0) 
        {  
            speed = 40;
            motor.motorSpeed = speed;
            joint.motor = motor;
            elevation += 0.5f;
        }
        else 
        {
            speed = 0;
            motor.motorSpeed = 0;
            joint.motor = motor;
        }
        
    }
}
