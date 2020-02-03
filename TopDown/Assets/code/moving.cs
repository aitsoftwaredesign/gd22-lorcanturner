using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class moving : MonoBehaviour
{
    public Transform target;
    float speed;
    // Start is called before the first frame update
    void Start()
    {
         
    }

    // Update is called once per frame
    void Update()
    {
        float speedDelta = speed * Time.deltaTime;
        Vector3 newPosition = myMoveTowards(speedDelta);
    }

    Vector3 myMoveTowards(float spd )
    {


        Vector3 currentPosition = transform.position;
        Vector3 destinationPosition = target.transform.position;
        Vector3 range = destinationPosition - currentPosition;
        Vector3 currentNorm = Vector3.Normalize.currentPosition;

        Debug.DrawRay(currentPosition, range, Color.red);
        Vector3 newPosition = currentPosition;
        return newPosition;
    }
}
