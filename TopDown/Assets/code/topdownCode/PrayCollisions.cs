using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class PrayCollisions : MonoBehaviour
{
    public static float playerLives = 5;

 
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
           
            playerLives = playerLives - 1;
                   
            if(playerLives < 1 )
            {
              Destroy(gameObject);
                //use this for the restart button
                SceneManager.LoadScene("TopDown");
                playerLives = playerLives + 5;
                bullet.dead = false;
            }
        }
    }
}
