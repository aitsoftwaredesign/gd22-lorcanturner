using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCasting : MonoBehaviour
{
    public Transform pickup;
    public Camera gameCamera;
    public float maxDist = 100;
    void Update()
    {

        Ray ray = gameCamera.ScreenPointToRay(Input.mousePosition);
        RaycastHit hitInfo;

        if(Physics.Raycast(ray, out hitInfo, maxDist) && Input.GetKey("e"))
        {
           // Debug.DrawLine(ray.origin.normalized, hitInfo.point , Color.red);
          //  pickup.position = hitInfo.point;
           // pickup.rotation = Quaternion.FromToRotation(Vector3.up, hitInfo.normal);

        }
        else
        {
            Debug.DrawLine(ray.origin, ray.origin + ray.direction * maxDist, Color.green);
        }
    }
}
