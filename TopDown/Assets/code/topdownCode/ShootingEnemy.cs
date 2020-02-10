using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingEnemy : MonoBehaviour
{
    public Transform pray;
    public float shEnemySpeed = 4;
    float speedDelta;
    float distance;
    public Transform firepoint;
    public GameObject bulletPrefab;
    float bulletForce = 10;
    float timer = 3;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        speedDelta = shEnemySpeed * Time.deltaTime;
        if(gameObject)
        {
            if (pray)
            {
                 distance = Vector3.Distance(pray.transform.position, transform.position);
                 Debug.Log("enemy is : " + distance + " units away from prey");
                 Vector3 range = pray.transform.position - transform.position;
                 Debug.DrawRay(transform.position, range, Color.magenta);
                 timer -= Time.deltaTime;
                 rotate();
                 if(gameObject)
                 { 
                      if(distance < 10 && distance >= 4f)
                      {
                            movement();
                      }
                      if(timer <= 0)
                    {
                        Shoot();
                        //    Debug.LogWarning("bullets are shooting. why cant you see them");
                        timer = 2f;
                    }
                 }

            }
        }
        


    }


    void movement()
    {
        
        follow();
    }
  
    
    void follow()
    {


        // follow
       
        transform.position = Vector3.MoveTowards(transform.position, pray.position, speedDelta);


        if (Vector3.Distance(transform.position, pray.position) < 0.00f)
        {
            pray.position *= -1.0f;
        }

    }

    void rotate()
    {       
        //rotation
        transform.eulerAngles = new Vector3(0, 0, -transform.eulerAngles.z ); //keeps enemy on z axis
        transform.LookAt(pray.position, transform.up);
        transform.Rotate(new Vector3(0, -90, 0), Space.Self);

    }

    public void Shoot()
    {
            if(gameObject)
             {
              GameObject bullet = Instantiate(bulletPrefab, firepoint.position, firepoint.rotation);
              Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
              rb.AddForce(firepoint.up * bulletForce, ForceMode2D.Impulse);
        
             }
       
       
        //not written yet
    }

}
