using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankShoot : MonoBehaviour
{
    public Camera cam1;
    public Camera cam2; 
    public GameObject bulletPrefab;
    public Transform firepoint;
    int switches = 0;
    public float bulletForce;
    bool next = false;

    // Start is called before the first frame update
    void Start()
    {
        cam1.enabled = false;
        cam2.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {


        if (SimpleTimer.currentTime > 6)
        {
            if (Input.GetKeyDown("space"))
            {
                Shoot();
                camSwitch();
                SimpleTimer.currentTime = 0;
                next = true;
            } 
      
        }
        if (SimpleTimer.currentTime > 6)
        {
            if(next == true)
            {
                camSwitch();
            }
            
            next = false;
        }


    }



    public void Shoot()
    {
        GameObject bullet = Instantiate(bulletPrefab, firepoint.position, firepoint.rotation) ;
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(firepoint.up * bulletForce, ForceMode2D.Impulse);
        
    }

    public void camSwitch()
    {

        switches++;
        if (switches % 2 == 0)
        {
            cam1.enabled = false;
            cam2.enabled = true;
        }
        else
        {
            cam1.enabled = true;
            cam2.enabled = false;
        }

    }
}
