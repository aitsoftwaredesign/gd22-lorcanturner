using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class partical : MonoBehaviour
{
    ParticleSystem p;
    // Start is called before the first frame update
    void Start()
    {
        p = GetComponent<ParticleSystem>();

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey("a"))
        {
           p.emissionRate = 10;
        }
        else
        {
            p.emissionRate = 0;
        }
       
    }
}
