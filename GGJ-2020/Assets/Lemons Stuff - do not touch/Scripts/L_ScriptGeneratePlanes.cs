using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class L_ScriptGeneratePlanes : MonoBehaviour
{
    public GameObject[] spawnPoints;
    public GameObject building;

    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < spawnPoints.Length; i++)
        {
           GameObject temp = Instantiate(building, spawnPoints[i].transform.position, Quaternion.identity);
            temp.transform.parent = spawnPoints[i].transform;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
