using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject walkerPrefab;
    private GameObject walkerGO;
    private Walker walkerComp;


    // Start is called before the first frame update
    void Start()
    {
        GameObject walkerGO = new GameObject();
        walkerComp = walkerGO.AddComponent<Walker>();
    }

    // Update is called once per frame
    void Update()
    {
        walkerComp.Step();
        walkerComp.Draw();
    }
}
