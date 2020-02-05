using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicChase : MonoBehaviour
{
    public Transform target;
    public float speed;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        follow();
        
    }

    public void follow()
    {
        float speedDelta = speed * Time.deltaTime;

        if(transform.position.x < target.transform.position.x)
        {
            transform.Translate(speedDelta , 0, 0);
        }
        else
        {
            transform.Translate(-speedDelta, 0, 0);
        }

        if (transform.position.y < target.transform.position.y)
        {
            transform.Translate(0,speedDelta , 0);
        }
        else
        {
            transform.Translate(0, -speedDelta, 0);
        }
    }
}
