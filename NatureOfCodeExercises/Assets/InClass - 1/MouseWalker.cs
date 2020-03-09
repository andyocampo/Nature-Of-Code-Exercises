using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseWalker : MonoBehaviour
{
    public float x;
    public float y;
    float num;
    GameObject walkerGO;
    public GameObject target;

    // Start is called before the first frame update
    void Start()
    {
        walkerGO = this.gameObject;


        x = 0;
        y = 0;
    }

    // Update is called once per frame
    void Update()
    { 
        //Debug.Log($"{mousePos}");
        num = Random.Range(0f, 1f);
        //Debug.Log(num);
        step();
        draw();

    }

    public void step()
    {
        float prob = Random.Range(0f, 1f);

        //Each frame choose a new Random number 0-1;
        //If the number is less than the the float take a step


        if(prob < 0.5f)
        {
            Debug.Log("Not following target");
            if (num < 0.4F)
            {
                x++;
            }
            else if (num < 0.6F)
            {
                x--;
            }
            else if (num < .8F)
            {
                y++;
            }
            else
            {
                y--;
            }

            walkerGO.transform.position = new Vector3(x, y, 0F);

        }
        else
        {
            Debug.Log("following");
            walkerGO.transform.position = Vector3.MoveTowards(walkerGO.transform.position, target.transform.position, 1f);

        }

    }

    //Now let's draw the path of the Mover by creating spheres in its position in the most recent frame.
    public void draw()
    {
        //This creates a sphere GameObject
        GameObject sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        //This sets our ink "sphere game objects" at the position of the Walker GameObject (walkerGO) at the current frame
        //to draw the path
        sphere.transform.position = new Vector3(walkerGO.transform.position.x, walkerGO.transform.position.y, 0F);
    }
}
