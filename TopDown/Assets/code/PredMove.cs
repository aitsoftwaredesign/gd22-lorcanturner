using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PredMove : MonoBehaviour
{
    public Transform pray;
    public Transform pred;
    public object prayObj;
    public float MovementSpeed = 1;
   


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
        if(Mathf.Abs(pred.transform.position.x - pray.transform.position.x) > MovementSpeed* Time.deltaTime)
        {
         if (pred.position.x > pray.position.x)
                {
                    transform.Translate(-(MovementSpeed * Time.deltaTime), 0, 0);
                }
                else
                {
                    transform.Translate(MovementSpeed * Time.deltaTime, 0, 0);
                }
         }
        if (Mathf.Abs(pred.transform.position.y - pray.transform.position.y) > MovementSpeed * Time.deltaTime)
        {
            if (pred.position.y > pray.position.y)
            {
                transform.Translate(0, -(MovementSpeed * Time.deltaTime), 0);
            }
            else
            {
                transform.Translate(0, MovementSpeed * Time.deltaTime, 0);
            }
        }
    }
}
