using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class L_ScriptMansSpawn : MonoBehaviour
{
    public GameObject mans;
    public GameObject mansSpawn;
    float timer;
    Quaternion rot = new Quaternion(0f, 90f, 0f, 0f);
    int timerNum;

    // Start is called before the first frame update
    void Start()
    {
        timerNum = GetNumber();
        //SpawnMans();

        /*
        for(int i = 0; i <= mansSpawn.Length; i++)
        {
            Instantiate(mans, mansSpawn[i].transform.position,Quaternion.identity);
        }*/
        
    }

    // Update is called once per frame
    void Update()
    {
       
        timer += Time.deltaTime;

        if (timer >= Mathf.RoundToInt(Random.Range(1, 5)))
        {
            SpawnMans();
            timer = 0;
            //timerNum = GetNumber();
        }
               
    }

    int GetNumber()
    {
        int i = Mathf.RoundToInt(Random.Range(1, 5));
        return i;
    }

    void SpawnMans()
    {
        Debug.Log(mans);
        //for (int i = 0; i <= mansSpawn.Length; i++)
        // {
        Instantiate(mans, mansSpawn.transform.position, mans.transform.rotation = rot);
       // }
    }
}
