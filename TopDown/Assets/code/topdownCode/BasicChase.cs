using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicChase : MonoBehaviour
{
    public Transform target;
    public float speed;
    float distance;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        distance = Vector3.Distance(gameObject.transform.position, target.transform.position);
        if (target) //simple bool if statement to not confuse the system when the player is destroyed
        {
            if(distance < 10)
            {
                follow();
            }
            
            
        }
       

      //  Debug.LogError(distance);
    }

    public void follow()
    {
      
            float speedDelta = speed * Time.deltaTime;
        
        if (Mathf.Abs(transform.position.x - target.transform.position.x) > speedDelta)
        {
            if (transform.position.x < target.transform.position.x)
            {
                if(SimpleTimer.slow == true)
                {
                    transform.Translate(speedDelta * SimpleTimer.slowMo, 0, 0);
                }
                else
                {
                    transform.Translate(speedDelta, 0, 0);
                }
               
            }
            else if (transform.position.x > target.transform.position.x)
            {
                if (SimpleTimer.slow == true)
                {
                    transform.Translate(-speedDelta * SimpleTimer.slowMo, 0, 0);
                }
                else
                {
                    transform.Translate(-speedDelta, 0, 0);
                }
                
            }
        }

        if (Mathf.Abs(transform.position.y - target.transform.position.y) > speedDelta)
        {
            if (transform.position.y < target.transform.position.y)
            {
                if (SimpleTimer.slow == true)
                {
                    transform.Translate( 0, speedDelta * SimpleTimer.slowMo, 0);
                }
                else
                {
                    transform.Translate( 0,speedDelta, 0);
                }
                
            }
            else if (transform.position.y > target.transform.position.y)
            {

                if (SimpleTimer.slow == true)
                {
                    transform.Translate( 0,-speedDelta * SimpleTimer.slowMo, 0);
                }
                else
                {
                    transform.Translate( 0,-speedDelta, 0);
                }
            }
        }
   
 
        

    }


}
