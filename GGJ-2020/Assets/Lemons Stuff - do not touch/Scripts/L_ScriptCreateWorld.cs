using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class L_ScriptCreateWorld : MonoBehaviour
{
    public GameObject groundPlane;
    public GameObject masterObject;

    // Start is called before the first frame update
    void Start()
    {
        CreateWorld();
    }

    void CreateWorld()
    {

        GameObject temp;
        GameObject prevTemp;
        GameObject prevTempX;
        masterObject = GameObject.Find("L_MasterObject");
        prevTemp = masterObject;
        prevTempX = prevTemp;
        for (int i = 0; i < 63; i++)
        {
            temp = Instantiate(groundPlane, new Vector3(prevTempX.transform.position.x, 0, prevTemp.transform.position.z+50), Quaternion.identity); ;
            prevTempX = temp;
            prevTemp = temp;
            temp.transform.parent = masterObject.transform;

            for (int j = 0; j < 63; j++)
            {
                temp = Instantiate(groundPlane, new Vector3(prevTemp.transform.position.x+50, 0, prevTemp.transform.position.z), Quaternion.identity);
                prevTemp = temp;
                temp.transform.parent = prevTempX.transform;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
