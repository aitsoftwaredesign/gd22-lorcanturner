using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class shoot : MonoBehaviour
{
    public Transform firepoint;
    public GameObject bulletPrefab;
    float mag = 5;
    public float bulletForce = 10f;
    public float maxKills;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("space"))
        {
            Shoot();
            mag = mag - 1;
        }
        reload();

        if(SimpleTimer.slow == true)
        {
            bulletForce = 0.75f;
        }
        else
        {
            bulletForce = 2;
        }

      //  Debug.LogError("going into the update");
        if (bullet.kills >= maxKills)
        {
           //' Debug.LogError("hella kills my dude!");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            bullet.kills = 0;
        }
    }
    void Shoot()
    {
        if (mag > 0)
        { 
            GameObject bullet = Instantiate(bulletPrefab, firepoint.position, firepoint.rotation);
            Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
            rb.AddForce(firepoint.up * bulletForce, ForceMode2D.Impulse);
       
        }
    }

    void reload()
    {
        if(Input.GetKeyDown("r"))
        {
            mag = 5;
        }
    }



  
}
