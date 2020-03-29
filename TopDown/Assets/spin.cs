using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spin : MonoBehaviour
{
    public float rpm = 500;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        float deltaSpeed = rpm * Time.deltaTime;
        if(SimpleTimer.slow == true)
        {
            gameObject.transform.Rotate(0, 0, deltaSpeed * SimpleTimer.slowMo);
        }
        else
        {
            gameObject.transform.Rotate(0, 0, deltaSpeed);
        }
       
    }
}
