using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bounce : MonoBehaviour
{
    //variables
    public GameObject mover;
    private float x;


    //object location and velocity
    private Vector3 location;
    private Vector3 velocity;

    //bounce limit
    private float xMin = -10, xMax = 10;
    private bool xHit = false;

    void Start()
    {
        location = new Vector3(0, 0, 0);
        velocity = new Vector3(.05f, .04f, 0.02f);
        mover = Instantiate(mover, location, Quaternion.identity);

    }

    void Update()
    {
        x = mover.transform.position.x;


        if (xHit)
        {
            mover.transform.position += velocity;
            if (x >= xMax)
            {
                xHit = false;
            }
        }
        else
        {
            mover.transform.position -= velocity;
            if (x < xMin)
            {
                xHit = true;
            }
        }
    }
}
