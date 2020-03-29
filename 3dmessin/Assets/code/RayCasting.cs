using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCasting : MonoBehaviour
{
    public Transform pickup;
    public Camera gameCamera;
    void Update()
    {

        Ray ray = gameCamera.ScreenPointToRay(Input.mousePosition);
        RaycastHit hitInfo;

        if(Physics.Raycast(ray, out hitInfo, 100))
        {
            Debug.DrawLine(ray.origin, hitInfo.point , Color.red);
            pickup.position = hitInfo.point;
            pickup.rotation = Quaternion.FromToRotation(Vector3.up, hitInfo.normal);

        }
        else
        {
            Debug.DrawLine(ray.origin, ray.origin + ray.direction * 100, Color.green);
        }
    }
}
