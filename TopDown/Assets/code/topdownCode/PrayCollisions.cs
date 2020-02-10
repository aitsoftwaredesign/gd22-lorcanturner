using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class PrayCollisions : MonoBehaviour
{
    

 
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
                SceneManager.LoadScene("challange 1");
                health.playerLives = health.playerLives + 5;
            }
        }
    }
}
