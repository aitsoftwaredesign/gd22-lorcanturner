using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class WheelMotion : MonoBehaviour
{
    public Transform wheel;
    public float rpm;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey("d"))
        {
            transform.Rotate(-Vector3.forward * rpm * Time.deltaTime);
        }
        else if(Input.GetKey("a"))
        {
            transform.Rotate(Vector3.forward * rpm * Time.deltaTime);
        }
    }
}
