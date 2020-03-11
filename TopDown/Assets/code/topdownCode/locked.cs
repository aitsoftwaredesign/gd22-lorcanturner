using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class locked : MonoBehaviour
{
    bool doorLocked = true;
    public float initMass;
    public float lockedMass;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(doorLocked == false)
        {
            gameObject.GetComponent<Rigidbody2D>().mass = initMass;
        }
        else
        {
            gameObject.GetComponent<Rigidbody2D>().mass = lockedMass;
        }

        if (PrayCollisions.keyAmount < 1)
        {
            PrayCollisions.hasKey = false;

        }
        else
        {
            PrayCollisions.hasKey = true;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player") && PrayCollisions.hasKey == true)
        {
           
            if(doorLocked == true)
            {
                PrayCollisions.keyAmount--;
            }
            doorLocked = false;

            

        }

            
    }
}
