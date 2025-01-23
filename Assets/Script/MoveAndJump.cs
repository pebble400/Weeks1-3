using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveAndJump : MonoBehaviour
{
    float speed = 1f;
    public AnimationCurve curve;
    [Range(0, 1)]
    public float t;

    bool isJumping = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 pos = transform.position;
        pos.y = curve.Evaluate(t);
        Vector3 rot = transform.eulerAngles;
        rot.z += speed;

        if (Input.GetKey(KeyCode.Space))
        {
            isJumping = true;
            transform.eulerAngles = rot;

        }
        if (isJumping == true)
        {
            t += Time.deltaTime;
            transform.position = pos;
            if (t > 1)
            {
                t = 0;
                isJumping = false;
                rot.z = 0;
            }

        }
    }
}
