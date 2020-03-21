using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collisions : MonoBehaviour
{
    // Start is called before the first frame update
    void onTriggerEnter(collisions collision)
    {
        if(collision.gameObject.CompareTag("obstical"))
        {
            Debug.Log("collision");
        }
    }
}
