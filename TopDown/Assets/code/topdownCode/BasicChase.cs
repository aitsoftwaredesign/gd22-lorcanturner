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
        if (target) //simple bool if statement to not confuse the system when the player is destroyed
        {
            follow();
        }
        

    }

    public void follow()
    {
      
            float speedDelta = speed * Time.deltaTime;
        if (Mathf.Abs(transform.position.x - target.transform.position.x) > speedDelta)
        {
            if (transform.position.x < target.transform.position.x)
            {
                transform.Translate(speedDelta, 0, 0);
            }
            else if (transform.position.x > target.transform.position.x)
            {
                transform.Translate(-speedDelta, 0, 0);
            }
        }

        if (Mathf.Abs(transform.position.y - target.transform.position.y) > speedDelta)
        {
            if (transform.position.y < target.transform.position.y)
            {
                transform.Translate(0, speedDelta, 0);
            }
            else if (transform.position.y > target.transform.position.y)
            {
                transform.Translate(0, -speedDelta, 0);
            }
        }
   
 
        

    }


}
