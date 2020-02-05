using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class killsText : MonoBehaviour
{
    
    Text killsAmount;

    // Start is called before the first frame update
    void Start()
    {
        killsAmount = GetComponent<Text>();
        
    }

    // Update is called once per frame
    void Update()
    {
        bullet b = GetComponent<bullet>();

        killsAmount.text = "Kills: " + bullet.kills;
    }
}
