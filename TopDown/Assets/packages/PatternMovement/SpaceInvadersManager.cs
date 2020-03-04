using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceInvadersManager : MonoBehaviour
{
    public GameObject spaceInvader;
    public Transform startTransform;
    public int columns;
    public int rows;

    // Use this for initialization
    void Start ()
    {
        // GameObject invaderClone = Instantiate(spaceInvader, transform.position, transform.rotation);
        // Instantiate space invaders on the screens
        
        for (int j = 0; j < columns; j++)
        {

            for (int k = 0; k < rows; k++)
            {
                Vector3 gap = new Vector3(j, k, 0);
                Instantiate(spaceInvader, startTransform.position + gap, transform.rotation);
            }
        }
        

    }
	
	// Update is called once per frame
	void Update ()
    {
		
	}
}