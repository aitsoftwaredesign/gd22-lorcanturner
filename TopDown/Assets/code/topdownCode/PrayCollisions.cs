using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrayCollisions : MonoBehaviour
{
    public float playerLives;
 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
 
        
    }

    void lives()
    {

    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("preditor"))
        {
            Destroy(collision.gameObject);
            playerLives = playerLives - 1;
                   
            if(playerLives < 1 )
            {
              Destroy(gameObject);
            }
        }
    }
}
