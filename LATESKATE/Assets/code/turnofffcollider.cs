using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turnofffcollider : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("s"))
        {
            this.GetComponent<BoxCollider2D>().enabled = false;
        }
        else if(Input.GetKey("d")|Input.GetKey("w"))
        {
            this.GetComponent<BoxCollider2D>().enabled = true;
        }
    }
}
