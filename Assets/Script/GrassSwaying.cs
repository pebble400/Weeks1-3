using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrassSwaying : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update() //Makes the triangles follow the position of the mouse at an offset to create a swaying effect
        //I put this script on an empty game object to create a makeshift pivot and set that as the parent of each grass blade
    {
        Vector3 mouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mouse.z = 0;
        Vector2 direction = mouse - transform.position;

        transform.up = direction; 
    }
}
