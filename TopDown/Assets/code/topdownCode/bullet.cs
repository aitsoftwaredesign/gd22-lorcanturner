using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    

    public static int kills = 0;
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("preditor"))
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
            kills = kills + 1;

        }
        
        if(collision.gameObject.CompareTag("obticle"))
        {
            Destroy(gameObject);
        }

       
        

    }
}
