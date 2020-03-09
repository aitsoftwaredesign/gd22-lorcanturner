using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointPatternMovement : MonoBehaviour
{
    public Transform[] pattern;
    private int patternIndex = 0;
    public float speed = 1;

    // Use this for initialization
    void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        // Process the current instruction in our control data array
       Transform waypoint = pattern[patternIndex];

        // Find the range to close vector
        Vector3 rangeToClose = waypoint.transform.position - transform.position;

        // Draw this vector at the position of the enemy
        Debug.DrawRay(transform.position, rangeToClose, Color.cyan);

        // What's our distance to the waypoint?
        float distance = rangeToClose.magnitude;

        // How far do we move each frame
        float speedDelta = speed * Time.deltaTime;

        // If we're close enough to the current waypoint 
        // then increase the pattern index

        if (distance <= speedDelta)
        {
            patternIndex++;
            // Reset the patternIndex if we are at the end of the instruction array
            if (patternIndex >= pattern.Length)
            {
                patternIndex = 0;
            }

            // Process the current instruction in our control data array
            waypoint = pattern[patternIndex];

            // Find the new range to close vector
            rangeToClose = waypoint.transform.position - transform.position;
        }

        // In what direction is our player?
        Vector3 normalizedRangeToClose = rangeToClose.normalized;

        // Draw this vector at the position of the waypoint
        Debug.DrawRay(transform.position, normalizedRangeToClose, Color.magenta);

        Vector3 delta = speedDelta * normalizedRangeToClose;

        transform.Translate(delta);

        transform.eulerAngles = new Vector3(0, 0, -transform.eulerAngles.z);
        transform.LookAt(pattern[patternIndex].position, transform.up);
        transform.Rotate(new Vector3(0, -90, 0), Space.Self);
    }


}
