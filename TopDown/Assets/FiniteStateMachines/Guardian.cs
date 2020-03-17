using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Guardian : MonoBehaviour {

    public enum GuardianState
    {
        PROTECT,
        CHASE
    };

    public GuardianState currentState = GuardianState.PROTECT;

    // Use this for initialization
    void Start ()
    {
       
        
    }
	
	// Update is called once per frame
	void Update ()
    {
        switch (currentState)
        {
            case GuardianState.PROTECT:
                // Process pattern movement
                //DoPatternMovement();
                break;
            case GuardianState.CHASE:
                // Do LOS chase
                //DoLOS();
                break;
            default:
                break;
        }

    }
}
