using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleTimer : MonoBehaviour
{
    
    public static float currentTime;
    public static float countDown;
    public static bool slow = false;
    public static float slowMo = .4f;
    
    
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        currentTime +=  Time.deltaTime;
        countDown -=  Time.deltaTime;
        
        if (countDown > 0)
        {
            slow = true;
        }
        else
        {
            slow = false;
        }

        //  Debug.Log(currentTime + " second have passed" );
       // Debug.Log(currentTime + "   " + slow);
    }
}
