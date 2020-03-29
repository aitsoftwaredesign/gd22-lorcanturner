using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class PrayCollisions : MonoBehaviour
{
    public static bool hasKey = false;
    public static int keyAmount = 0;

 
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
           
            health.playerLives = health.playerLives - 1;
                   
            if(health.playerLives < 1 )
            {
              Destroy(gameObject);
                //use this for the restart button
                Death.dead();
            }
        }

        if(collision.gameObject.CompareTag("key"))
        {
            Destroy(collision.gameObject);
           
            keyAmount++;
        }

        if(collision.gameObject.CompareTag("health"))
        {
            if(health.playerLives < 5)
            {
                health.playerLives++;
                Destroy(collision.gameObject);
            }
        }

        if(collision.gameObject.CompareTag("spinner"))
        {
            health.playerLives -= 1;
            
        }
        if(collision.gameObject.CompareTag("enemy"))
        {
            health.playerLives = health.playerLives - 1;

            if (health.playerLives < 1)
            {
                Destroy(gameObject);
                //use this for the restart button
                Death.dead();
            }
        }
        if (collision.gameObject.CompareTag("time"))
        {
            Destroy(collision.gameObject);
            SimpleTimer.countDown = 150;
        }
    }


}
