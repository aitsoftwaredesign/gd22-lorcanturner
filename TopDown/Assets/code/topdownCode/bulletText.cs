using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bulletText : MonoBehaviour
{
   public static int bulletValue = 5;
    Text bullets;

    // Start is called before the first frame update
    void Start()
    {
        bullets = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if(bulletValue > 0)
        { 
            if(Input.GetKeyDown("space"))
             {
                 bulletValue = bulletValue - 1;
            }
            bullets.text = "Bullets: " + bulletValue + "/5";
        }
        else
        {
            bullets.text = "Bullets: " + bulletValue + "/5   reload : R";
        }
       
        if(Input.GetKey("r"))
        {
            bulletValue = 5;
        }



        

    }
}
