using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walker : MonoBehaviour
{
    GameObject walkerObject;
    protected int x;
    protected int y;

    // Start is called before the first frame update
    void Start()
    {
        walkerObject = this.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void Step()
    {
        int choice = Random.Range(0, 6);

        switch(choice)
        {
            case 0:
                x++;
                break;
            case 1:
                x++;
                break;
            case 2:
                x--;
                break;
            case 3:
                y++;
                break;
            case 4:
                y--;
                break;
            case 5:
                x++;
                break;
            case 6:
                y--;
                break;

        }
        walkerObject.transform.position = new Vector3(x, y, 0);
    }

    public void Draw()
    {
        GameObject sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        Destroy(sphere.GetComponent<SphereCollider>());
        sphere.transform.position = new Vector3(walkerObject.transform.position.x, walkerObject.transform.position.y, 0);
    }
}

