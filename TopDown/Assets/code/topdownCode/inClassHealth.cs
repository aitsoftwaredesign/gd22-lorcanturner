using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inClassHealth : MonoBehaviour
{
   
    public int health = 50;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
 
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("preditior"))
        {
            health -= 10;
        }
    }


}
