using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpenClose : MonoBehaviour
{//using both lerp and curve to create a door sliding animation for when the door is clicked
    [Range(0, 1)]
    public float t;
    public AnimationCurve curve;
    public Transform start;
    public Transform end;
    bool isOpen = false; 
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 pos = transform.position;
        pos.y = curve.Evaluate(t);

        if (Input.GetMouseButtonDown(0) || t > 0)//if the door is clicked and if the variable t (time) is greater than zero, t will go up by one each frame and change the position of the door
        {
            isOpen = true;
            t += Time.deltaTime;
            transform.position = Vector2.Lerp(start.position, end.position, curve.Evaluate(t));//setting the start position of the door
        }
        else if (isOpen == true)
        {
            t -= Time.deltaTime;
            transform.position = Vector2.Lerp(end.position, start.position, curve.Evaluate(t));//setting the end position of the door

        }
    }
}
