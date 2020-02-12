using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PredMove : MonoBehaviour
{
    public Transform prayObj;
    public float speed = 1;
    float distance;
    public float followPlayerDistance;
    public Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        
    }


    // Update is called once per frame
    void Update()
    {
        if (prayObj && health.playerLives <= 3)
        {
            distance = Vector3.Distance(prayObj.transform.position, transform.position);
            Debug.Log("enemy is : " + distance + " units away from prey" );
        
                if (distance < followPlayerDistance)
                {  
                    Vector3 range =  prayObj.transform.position - transform.position;
                    Debug.DrawRay(transform.position, range, Color.green);
                    follow();
                    rotateTowards();

                }
          
        }
    }

    void follow()
    {
       float speedDelta = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, prayObj.position, speedDelta);


        if (Vector3.Distance(transform.position, prayObj.position) < 0.00f)
        {
            prayObj.position *= -1.0f;
        }
    }

    private void rotateTowards()
    {
        transform.eulerAngles = new Vector3(0, 0, -transform.eulerAngles.z);
        transform.LookAt(prayObj.position, transform.up);
        transform.Rotate(new Vector3(0, -90, 0), Space.Self);
    }
}
