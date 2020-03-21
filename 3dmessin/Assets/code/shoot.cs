using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform firepoint;
    public GameObject bulletP;
    public float bulletForce;
    public float speed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float deltaSpeed = speed * Time.deltaTime;
        
        if (Input.GetKeyDown("e"))
        {
            Debug.Log("shooting");

            GameObject bullet = Instantiate(bulletP, firepoint.position, firepoint.rotation);
            Rigidbody rb = bullet.GetComponent<Rigidbody>();
            rb.AddForce(firepoint.up * bulletForce, ForceMode.Impulse);
           
        }
        
    }


}
