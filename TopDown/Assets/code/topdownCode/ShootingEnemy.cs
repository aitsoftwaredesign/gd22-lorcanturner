using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingEnemy : MonoBehaviour
{
    public Transform preditionPoint;
    public Transform pray;
    public float shEnemySpeed = 0;
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
                PredictPosition();
                 distance = Vector3.Distance(pray.transform.position, transform.position);
                 Debug.Log("enemy is : " + distance + " units away from prey");
                
        
                
                 timer -= Time.deltaTime;
               
                 rotate();
                 if(gameObject)
                 { 
                      if(distance < 10 && distance >= 4f)
                      {
                            movement();
                      }
                      if(timer <= 0 && distance <= 10)
                     {
                        Shoot();
                        //    Debug.LogWarning("bullets are shooting. why cant you see them");
                        timer = 2f;
                       }
         
                 }

            }
            else
            {
                DestroyImmediate(bulletPrefab);
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

    void PredictPosition()
    {
        if(prayMove.currentSpeed > 5)
        {
            Vector3 range = preditionPoint.transform.position - transform.position;
            Debug.DrawRay(transform.position, range, Color.cyan);
        }
        else
        {
            Vector3 range = pray.transform.position - transform.position;
            Debug.DrawRay(transform.position, range, Color.cyan);
        }

        /*Vector3 futurePosition = pray.transform.position + (transform.position * (shEnemySpeed * Time.deltaTime));
        Vector3 predictedRange = pray.transform.position - transform.position;
        Debug.DrawLine(transform.position, futurePosition, Color.cyan);*/
    }

    void rotate()
    {
        //rotation
        if (prayMove.currentSpeed > 5)
        {
            transform.eulerAngles = new Vector3(0, 0, -transform.eulerAngles.z); //keeps enemy on z axis
            transform.LookAt(preditionPoint.position, transform.up);
            transform.Rotate(new Vector3(0, -90, 0), Space.Self);
        }
        else
        {
            transform.eulerAngles = new Vector3(0, 0, -transform.eulerAngles.z ); //keeps enemy on z axis
            transform.LookAt(pray.position, transform.up);
            transform.Rotate(new Vector3(0, -90, 0), Space.Self);
        }
            

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
