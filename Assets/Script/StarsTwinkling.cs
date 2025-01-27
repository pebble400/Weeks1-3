using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarsTwinkling : MonoBehaviour
{
    Vector2 starScale; //setting the scale of the starts to a costum scale
    public float speed = 0.1f; //Declaring a speed variable so I can change the speed using a speed handle
    public AnimationCurve curve;//using animation curve to make the stars pop in and out, using different graphs to create a more natural twinkle effect
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

        t += Time.deltaTime + speed;

        if (t > 1)
        {
            t = 0;
        }
        transform.localScale = starScale * curve.Evaluate(t);

    }
}
