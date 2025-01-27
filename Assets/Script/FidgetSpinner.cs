using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FidgetSpinner : MonoBehaviour
{
    float speed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 rot = transform.eulerAngles;//assigning the position 
        rot.z += speed;


        if (Input.GetKey(KeyCode.Space))//rotates the fidget spinner only if the space bar is pressed
        {
            transform.eulerAngles = rot;
        }
    }
}
