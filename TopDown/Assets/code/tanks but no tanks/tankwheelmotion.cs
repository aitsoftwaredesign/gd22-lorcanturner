using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tankwheelmotion : MonoBehaviour
{
    public WheelJoint2D wheel;
    public float speed = 100f;

    // Start is called before the first frame update
    void Start()
    {
        wheel = GetComponent<WheelJoint2D>();
       
    }

    // Update is called once per frame
    void Update()
    {
        JointMotor2D motor;
        motor = wheel.motor;

        if(Input.GetKeyDown("d"))
        {
            motor.motorSpeed = speed;
            wheel.motor = motor;
        }
        if (Input.GetKeyDown("a"))
        {
           motor.motorSpeed = -speed;
            wheel.motor = motor;
            soundFX.playSound("driving");
        }
        else if(Input.GetKeyUp("d")||Input.GetKeyUp("a"))
        {
            motor.motorSpeed = 0;

            wheel.motor = motor;
            soundFX.stopSound("cannon");
        }
        else if(Input.GetKeyDown("s"))
        {
            motor.motorSpeed = 0;

            wheel.motor = motor;
        }
        Debug.Log(speed);
    }
}
