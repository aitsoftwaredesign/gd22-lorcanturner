using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class patroling : MonoBehaviour
{
    public GameObject[] pattern;
    private int patternIndex = 0;
    public float speed = 2;


    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        GameObject waypoint = pattern[patternIndex];

        Vector3 range = waypoint.transform.position - transform.position;

        Debug.DrawRay(transform.position, range, Color.red);

        float distance = range.magnitude;

        float deltaSpeed = speed * Time.deltaTime;

        if(distance <= deltaSpeed)
        {
            patternIndex++;

            if(patternIndex >= pattern.Length)
            {
                patternIndex = 0;

            }
            waypoint = pattern[patternIndex];

            range = waypoint.transform.position - transform.position;
        }

        Debug.DrawRay(transform.position, range.normalized, Color.blue);

        Vector3 dist = deltaSpeed * range.normalized;

            transform.Translate(dist);
   



    }
}
