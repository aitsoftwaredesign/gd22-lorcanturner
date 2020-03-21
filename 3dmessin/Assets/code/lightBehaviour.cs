using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightBehaviour : MonoBehaviour
{


    void onTriggerEnter(Collision col)
    {
        Debug.Log("collision");
        if (col.gameObject.name == "preasure plate")
        {
            Debug.LogError("purple!");
        }
    }

    void Update()
    { 
    }
}
