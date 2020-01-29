using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrayCollisions : MonoBehaviour
{
    public float playerLives;
    public GameObject preditor;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(playerLives < 1 )
        {
            Destroy(gameObject);
        }
        
    }

    void OnCollisionEnter(Collision collision)
    {
      if(collision.gameObject.CompareTag("preditor"))
        {
            Destroy(collision.gameObject);
            playerLives = playerLives - 1;
        }
    }
}
