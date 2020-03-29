using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class moving : MonoBehaviour
{
    float distance;
    public Transform target;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
         
    }

    // Update is called once per frame
    void Update()
    {


        Debug.Log(distance + "you are units away from enemy");
 
        float speedDelta = speed * Time.deltaTime;

        
        Vector3 newPosition = myMoveTowards(speedDelta);
        transform.position = newPosition;
       
        
       
       
    }

    Vector3 myMoveTowards(float spd )
    {
        
        Vector3 currentPosition = transform.position;
        Vector3 destinationPosition = target.transform.position;
        Vector3 range = destinationPosition - currentPosition;
        

        Debug.DrawRay(currentPosition, range, Color.red);
       

       // length of the normilised line
        Debug.DrawRay(currentPosition, range.normalized, Color.blue);


        //move depeed delta along the normalised range
        
        Vector3 velocity = range.normalized * spd;
   


        Vector3 newPosition = currentPosition + velocity;
        return newPosition;
    }
}
