using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class sceneChanger : MonoBehaviour
{
    // Start is called before the first frame update
    public float sceneMaxKills;
    void start()
    {
        bullet.maxKills = sceneMaxKills;
    }

    void update()
    {

    }
    public static void changeScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
    }
}
