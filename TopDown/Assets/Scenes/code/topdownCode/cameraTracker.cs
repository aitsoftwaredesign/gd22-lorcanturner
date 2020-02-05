using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraTracker : MonoBehaviour
{
    public float whatsPlayersTurnSpeed = 400;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Negate();
    }



    //negates the effect of camera rotation
    void Negate()
    {
        if (Input.GetKey("d"))
        {
            transform.Rotate(Vector3.forward * whatsPlayersTurnSpeed * Time.deltaTime);
        }

        if (Input.GetKey("a"))
        {
            transform.Rotate(-Vector3.forward * whatsPlayersTurnSpeed * Time.deltaTime);
        }
    }
}
