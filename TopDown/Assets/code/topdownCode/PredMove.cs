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
        if (prayObj)
        {
            distance = Vector3.Distance(prayObj.transform.position, transform.position);
            Debug.Log("enemy is : " + distance + " units away from prey" );
            if (bullet.dead == false)
            {
                if (distance < followPlayerDistance)
                {
                    follow();
                    rotateTowards();
                    anim.SetFloat("speed", 1);
                }
                else
                {
                    anim.SetFloat("speed", 0);

                }
            } 
    
             if(bullet.dead == true)
             {
                 anim.SetBool("isShot", true);
               

             }
            else
            {
                anim.SetBool("isShot", false);
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
