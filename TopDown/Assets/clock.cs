using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clock : MonoBehaviour
{
    SpriteRenderer sr;

    // Start is called before the first frame update
    void Start()
    {
        sr = gameObject.GetComponent<SpriteRenderer>();

    }

    // Update is called once per frame
    void Update()
    {
        if(SimpleTimer.slow == false)
        {
            sr.enabled = true;
        }
        else
        {
            sr.enabled = false;
        }
    }
}
