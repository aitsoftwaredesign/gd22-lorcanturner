using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;



public class bullet : MonoBehaviour
{
    
    public static int kills = 0;

    void update()
    {

    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("preditor"))
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
            kills = kills + 1;


            if (kills > 5)
            {
                Debug.Log("hella kills my dude!");
                SceneManager.LoadScene("simpleYouWin");
                kills = 0;
            }

        }
        
        if(collision.gameObject.CompareTag("obticle"))
        {
            Destroy(gameObject);
            
        }

        if(collision.gameObject.CompareTag("Player"))
        {
            health.playerLives -= 1;
            Destroy(gameObject);
           //animation for bullet will be added
            if(health.playerLives < 1)
            {
                Destroy(collision.gameObject);
            }

        }

       
        

    }
}
