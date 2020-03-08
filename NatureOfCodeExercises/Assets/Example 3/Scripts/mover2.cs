using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mover2 : MonoBehaviour
{
    public Vector3 location;
    public Vector3 velocity;
    public Vector3 acceleration;
    public Vector3 topSpeed;

    private GameObject mover;
    private float x, y, z;

    private float xMin = -10, xMax = 10, yMin = -10, yMax = 10, zMin = -10, zMax = 10;
    private bool xHit = true, yHit = true, zHit = true;

    void Awake()
    {
        mover = this.gameObject;

        location = new Vector3(0F, 0F, 0F);
        velocity = new Vector3(0F, 0F, 0F);
        acceleration = new Vector3(.001F, .0001F, 0F);

        mover.transform.position = location;
    }

    void Update()
    {

        if ((location.x >= xMin) && (location.x <= xMax) && (location.y >= yMin) && (location.y <= yMax) && (location.z >= zMin) && (location.z <= zMax))
        {
            if (velocity.magnitude <= topSpeed.magnitude)
            {
                velocity += new Vector3(acceleration.x, acceleration.y, acceleration.z);
                location += new Vector3(velocity.x, velocity.y, velocity.z);
                mover.transform.position = location;
            }
            else
            {
                velocity += new Vector3(acceleration.x, acceleration.y, acceleration.z);
                location += new Vector3(velocity.x, velocity.y, velocity.z);
                mover.transform.position = location;
            }
        }
        else
        {
            Boundries();
        }

    }

    void Boundries()
    {
        x = location.x;
        y = location.y;
        z = location.z;

        if (xHit)
        {

            location = new Vector3(0F, 0F, 0F);

        }
        else if (yHit)
        {

            location = new Vector3(0F, 0F, 0F);

        }
        else if (zHit)
        {

            location = new Vector3(0F, 0F, 0F);

        }
    }

    public void subtractVector(Vector3 originalV3, Vector3 v3)
    {
        x = originalV3.x - v3.x;
        y = originalV3.y - v3.y;
        z = originalV3.z - v3.z;

        Vector3 subtractedVector = new Vector3(x, y, z);
        subtractedVector.Normalize();

        multiplyVector(subtractedVector, .0003f);

    }


    void multiplyVector(Vector3 transformPosition, float n)
    {
        x = transformPosition.x * n;
        y = transformPosition.y * n;
        z = transformPosition.z * n;

        acceleration = new Vector3(x, y, z);
    }


}
