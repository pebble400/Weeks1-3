using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LerpDemo : MonoBehaviour
{

    [Range(0, 1)]
    public float t;
    public AnimationCurve curve;
    public Transform start;
    public Transform end;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (t < 1 || t < 0)
        {
            t += Time.deltaTime;
            transform.position = Vector2.Lerp(start.position, end.position, curve.Evaluate(t));
        }
        else
        {
            t -= Time.deltaTime;
            transform.position = Vector2.Lerp(end.position, start.position, curve.Evaluate(t));

        }

    }
}
