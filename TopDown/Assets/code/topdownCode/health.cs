using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class health : MonoBehaviour
{
    public static float playerLives = 5;
    public GameObject healthScale;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        lives();
        
    }

    public void lives()
    {
        if (playerLives == 5)
        {
            healthScale.transform.localScale = new Vector3(-1f, 1, -0.3f);
        }
        else if (playerLives == 4)
        {
            healthScale.transform.localScale = new Vector3(-0.7f, 1, -0.3f);
        }
        else if (playerLives == 3)
        {
            healthScale.transform.localScale = new Vector3(-0.5f, 1, -0.3f);
        }
        else if (playerLives == 2)
        {
            healthScale.transform.localScale = new Vector3(-0.3f, 1, -0.3f);
        }
        else if (playerLives == 1)
        {
            healthScale.transform.localScale = new Vector3(0f, 1, 1);
        }
    }

  
}
