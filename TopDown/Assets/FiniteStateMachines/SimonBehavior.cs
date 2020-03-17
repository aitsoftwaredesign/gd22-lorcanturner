using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimonBehavior : MonoBehaviour
{

    public enum SimonState
    {
        SLEEPING,
        HAPPY
    };

    private SimonState state;
    private float timer = 0;

    // Use this for initialization
    void Start()
    {
        InitSleepingState();
    }

    // Update is called once per frame
    void Update()
    {
        // What state are we in?
        switch (state)
        {
            case SimonState.SLEEPING:
                // Process Sleeping State
                ProcessSleepingState();
                // Check for transition to another state
                CheckForTransitionFromSleeping();
                break;
            case SimonState.HAPPY:
                // Process Sleeping State
                ProcessHappyState();
                // Check for transition to another state
                CheckForTransitionFromHappy();
                break;
        }

    }

    void InitSleepingState()
    {
        Debug.Log("Sleeping");
        // Set the state
        state = SimonState.SLEEPING;
        // Get a random noumber between 3 and 10
        timer = Random.Range(3.0f, 10.0f);
        Debug.Log("Sleeping timer set to: " + timer);
    }


    void ProcessSleepingState()
    {
        // Do nothing for now. 
        // We could add a sleep sprite animation later.
    }

    void CheckForTransitionFromSleeping()
    {
        // Update the timer
        timer -= Time.deltaTime;
        // Check if we need to transition
        if (timer < 0.0f)
        {
            InitHappyState();
        }

    }

    void InitHappyState()
    {
        // Set the state
        state = SimonState.HAPPY;
       
        Debug.Log("Happy");
    }


    void ProcessHappyState()
    {
    
    }

    void CheckForTransitionFromHappy()
    {
       

    }

    
}

