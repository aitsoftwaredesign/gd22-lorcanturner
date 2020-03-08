using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class bulletE : MonoBehaviour
{

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("preditor"))
        {
            Destroy(gameObject);
        }

        if (collision.gameObject.CompareTag("obticle"))
        {
            Destroy(gameObject);
        }

        if (collision.gameObject.CompareTag("Player"))
        {
            health.playerLives -= 1;
          
            //animation for bullet will be added
            if (health.playerLives < 1)
            {
                if(gameObject)
                {
                    Destroy(gameObject);
                }
                Death.dead();
            }
            else
            {
                Destroy(gameObject);
            }
        }
    }
}
