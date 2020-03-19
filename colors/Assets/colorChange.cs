using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colorChange : MonoBehaviour
{
    public float speed = 0;
    public float deltaSpeed = speed * Time.deltaTime();
    public LineRenderer lines;
    // Start is called before the first frame update
    void Start()
    {
        lines.GetComponent<LineRenderer>();
       
    }

    // Update is called once per frame
    void Update()
    {

        lines.SetColors(Color.red,Color.blue);
    }
}
