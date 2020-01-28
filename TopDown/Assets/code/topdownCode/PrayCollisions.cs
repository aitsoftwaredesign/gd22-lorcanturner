using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrayCollisions : MonoBehaviour
{
    public Transform pray;
    public Rigidbody2D boundry;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "wall")  // or if(gameObject.CompareTag("YourWallTag"))
        {
            transform.Translate(0, 0, 0);
           
        }
    }
}
