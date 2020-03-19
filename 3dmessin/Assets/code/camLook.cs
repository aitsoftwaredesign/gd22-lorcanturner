using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camLook : MonoBehaviour
{
    public float mouseSencetivity = 5;
    public float smoothing = 2;
    public GameObject Player;
    Vector2 smoothV;
    Vector2 mouseLook;
   

    void Start()
    {
        Player = this.transform.parent.gameObject;
        Cursor.lockState = CursorLockMode.Locked;
    }
    void Update()
    {
        var md = new Vector2(Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y"));

        smoothV.x = Mathf.Lerp(smoothV.x, md.x, 1 / smoothing);
        smoothV.y = Mathf.Lerp(smoothV.y, md.y, 1 / smoothing);
        mouseLook += smoothV;
        
        transform.localRotation = Quaternion.AngleAxis(-mouseLook.y , Vector3.right);
        Player.transform.localRotation = Quaternion.AngleAxis(mouseLook.x, Player.transform.up);


        if (Input.GetKeyDown("escape"))
        {
            Cursor.lockState = CursorLockMode.None;
        }
    }

}
