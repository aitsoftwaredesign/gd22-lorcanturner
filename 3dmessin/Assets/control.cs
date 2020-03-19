using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class control : MonoBehaviour
{
    
    public float speed = 0.5f;
    public GameObject bullet;

    public float timer;
    // Start is called before the first frame update
    void Start()
    {
       
    
    }

    // Update is called once per frame
    void Update()
    {

        timer += Time.deltaTime;
        float deltaSpeed = speed * Time.deltaTime;
        if(bullet.gameObject)
        {
           
             if(timer > 2)
             {
                  timer = 0;
                     DestroyImmediate(bullet.gameObject, true);
             }
        }
       
       // Debug.Log(timer);
        if (Input.GetKey("space"))
        {
            jump();
        }
        else if (Input.GetKey("a"))
        {
             transform.Translate(  -speed ,0, 0);
        }
        else if (Input.GetKey("d"))
        {
              transform.Translate( speed, 0, 0);
        }
        else if (Input.GetKey("s"))
        {
            transform.Translate(0, 0, -speed);

        }
        else if (Input.GetKey("w"))
        {
            transform.Translate(0, 0, speed);
        }
      

    }

    public void jump()
    {

        transform.Translate(0,0.5f, 0);
    }
}
