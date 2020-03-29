using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class petrolingenemy : MonoBehaviour
{
    public Transform preditionPoint;
    public Transform pray;
    public float shEnemySpeed = 4;
    float speedDelta;
    float distance;
    public float posRange;
    public float negRange;
    public Transform firepoint;
    public GameObject bulletPrefab;
    float bulletForce = 1;
    float timer = 3;
    public Transform[] pattern;
    private int patternIndex = 0;
    public float speed = 2;


    // Start is called before the first frame update
    void Start()
    {

    }

    public enum states
    {
        CHASE,
        PATROL,
        STILL
    };
    public states current = states.PATROL;

    // Update is called once per frame
    void Update()
    {
        shEnemySpeed = 4;
        speedDelta = shEnemySpeed * Time.deltaTime;
        if (gameObject)
        {
            if (pray)
            {
                switch(current)
                {
                    case states.CHASE:
                        PredictPosition();
                        rotate();
                        follow();
                        break;

                    case states.PATROL:
                        petrol();
                        break;

                    case states.STILL:
                        PredictPosition();
                        rotate();
                        break;
                }

                checkForTransition();
                distance = Vector3.Distance(pray.transform.position, transform.position);
                //Debug.Log("enemy is : " + distance + " units away from prey");
                timer -= Time.deltaTime;
             
            } 
        }
    }

    public void checkForTransition()
    {
        if (gameObject)
        {  
            if (distance < posRange && distance > negRange)
            {
                current = states.CHASE;
                if (timer <= 0)
                {
                    shoot();
                    timer = 2f;
                }
            }
            else if (distance < negRange)
            {
                shEnemySpeed = 0;
                if (timer <= 0)
                {
                    shoot();
                    timer = 2f;
                }
                current = states.STILL;
            }
            else
            {
                current = states.PATROL;
                rotate();
            }
        }
    }

    public void petrol()
    {
        Transform waypoint = pattern[patternIndex];

        Vector3 range = waypoint.transform.position - transform.position;

        Debug.DrawRay(transform.position, range, Color.red);

        float distance = range.magnitude;

        float deltaSpeed = speed * Time.deltaTime;

        if (distance <= deltaSpeed)
        {
            patternIndex++;

            if (patternIndex >= pattern.Length)
            {
                patternIndex = 0;

            }
            waypoint = pattern[patternIndex];

            range = waypoint.transform.position - transform.position;
        }

        Debug.DrawRay(transform.position, range.normalized, Color.blue);

        Vector3 dist = deltaSpeed * range.normalized;

        if(SimpleTimer.slow == true)
        {
            transform.position = Vector3.MoveTowards(transform.position, waypoint.position, speedDelta * SimpleTimer.slowMo);
        }
        else
        {
            transform.position = Vector3.MoveTowards(transform.position, waypoint.position, speedDelta);
        }
       
    }

    void follow()
    {
        if(SimpleTimer.slow == true)
        {
            transform.position = Vector3.MoveTowards(transform.position, pray.position, speedDelta * SimpleTimer.slowMo);
        }
        else
        {
            transform.position = Vector3.MoveTowards(transform.position, pray.position, speedDelta);
        }
        
        if (Vector3.Distance(transform.position, pray.position) < 0.00f)
        {
            pray.position *= -1.0f;
        }

    }

    void PredictPosition()
    {

        if (prayMove.currentSpeed > 5)
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
        Transform waypoint = pattern[patternIndex];
        //rotation
        if (distance < posRange)
        {
             if (prayMove.currentSpeed > 5)
                    {
                        transform.eulerAngles = new Vector3(0, 0, -transform.eulerAngles.z); //keeps enemy on z axis
                        transform.LookAt(preditionPoint.position, transform.up);
                        transform.Rotate(new Vector3(0, -90, 0), Space.Self);
                    }
                    else
                    {
                        transform.eulerAngles = new Vector3(0, 0, -transform.eulerAngles.z); //keeps enemy on z axis
                        transform.LookAt(pray.position, transform.up);
                        transform.Rotate(new Vector3(0, -90, 0), Space.Self);
                    }
        }
        else
        {
            transform.eulerAngles = new Vector3(0, 0, -transform.eulerAngles.z); //keeps enemy on z axis
            transform.LookAt(waypoint.position, transform.up);
            transform.Rotate(new Vector3(0, -90, 0), Space.Self);
        }
       


    }

    public void shoot()
    {
        if (SimpleTimer.slow == true)
        {
            bulletForce = 0.1f;
        }
        else
        {
            bulletForce = 1;
        }
        if (gameObject)
        {
            GameObject bullet = Instantiate(bulletPrefab, firepoint.position, firepoint.rotation);
            Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
            rb.AddForce(firepoint.up * bulletForce, ForceMode2D.Impulse);

        }

    }

}
