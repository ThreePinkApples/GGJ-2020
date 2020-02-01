using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class L_ScriptMansSpawn : MonoBehaviour
{
    public GameObject mans;
    public GameObject[] mansSpawn;
    float timer;

    // Start is called before the first frame update
    void Start()
    {

        for(int i = 0; i <= mansSpawn.Length; i++)
        {
            Instantiate(mans, mansSpawn[i].transform.position,Quaternion.identity);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
       
        timer += Time.deltaTime;
    /*
        if(timer >= 3)
        {
            SpawnMans();
            timer = 0;
        }*/
               
    }

    void SpawnMans()
    {
        for (int i = 0; i <= mansSpawn.Length; i++)
        {
            Instantiate(mans, mansSpawn[i].transform.position, Quaternion.identity);
        }
    }
}
