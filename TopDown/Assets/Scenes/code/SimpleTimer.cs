using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleTimer : MonoBehaviour
{
    
    public static float currentTime;
    
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        currentTime += (1 * Time.deltaTime);
        Debug.Log(currentTime + " second have passed" );
    }
}
