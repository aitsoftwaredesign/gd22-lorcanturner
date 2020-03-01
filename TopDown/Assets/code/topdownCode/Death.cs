using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Death : MonoBehaviour
{
    // Start is called before the first frame update
    public static void dead()
    {
       
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        health.playerLives = 5;
        bullet.kills = 0;
    }
}
