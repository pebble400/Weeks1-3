using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarsTwinkling : MonoBehaviour
{
    Vector2 starScale;
    public float speed = 0.1f;
    public AnimationCurve curve;
    [Range(0, 1)]
    public float t;
    // Start is called before the first frame update
    void Start()
    {
        starScale = transform.localScale;
    }

    // Update is called once per frame
    void Update()
    {
        t += Time.deltaTime;

        if (t > 1)
        {
            t = 0;
        }
        transform.localScale = starScale * curve.Evaluate(t);
    }
}
