using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class health : MonoBehaviour
{
    
    public GameObject healthScale;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(PrayCollisions.playerLives == 5)
        {
            healthScale.transform.localScale = new Vector3(-1f, 1, -0.3f);
        }
        else if(PrayCollisions.playerLives == 4)
        {
            healthScale.transform.localScale = new Vector3(-0.7f, 1, -0.3f);
        }
        else if(PrayCollisions.playerLives == 3)
        {
            healthScale.transform.localScale = new Vector3(-0.5f, 1, -0.3f);
        }
        else if (PrayCollisions.playerLives == 2)
        {
            healthScale.transform.localScale = new Vector3(-0.3f, 1, -0.3f);
        }
        else if (PrayCollisions.playerLives == 1)
        {
            healthScale.transform.localScale = new Vector3(0f, 1, 1);
        }
        
    }

  
}
