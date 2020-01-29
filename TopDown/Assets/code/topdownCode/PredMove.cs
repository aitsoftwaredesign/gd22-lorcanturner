using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PredMove : MonoBehaviour
{
    public Transform prayObj;
    public float speed = 1;

   


    // Start is called before the first frame update
    void Start()
    {
        
    }


    // Update is called once per frame
    void Update()
    {
        follow();
    }

    void follow()
    {
       float speedDelta = speed * Time.deltaTime;

        transform.position = Vector3.MoveTowards(transform.position, prayObj.position, speedDelta);

        if(Vector3.Distance(transform.position, prayObj.position) < 0.00f)
        {
            prayObj.position *= -1.0f;
        }

       
    }
}
