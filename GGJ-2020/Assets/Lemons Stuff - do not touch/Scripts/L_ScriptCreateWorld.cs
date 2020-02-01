using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class L_ScriptCreateWorld : MonoBehaviour
{

    public GameObject masterObject;
    public GameObject groundPlane;
    public GameObject groundPlaneCorner;
    public GameObject groundPlaneEdge;
    GameObject temp;
    int currentI;

    // Start is called before the first frame update
    void Start()
    {
        CreateWorld();
    }

    void CreateWorld()
    {
        //GameObject temp;
        GameObject prevTemp;
        GameObject prevTempX;
        masterObject = GameObject.Find("L_MasterObject");
        prevTemp = masterObject;
        prevTempX = prevTemp;
        for (int i = 0; i <= 63; i++)
        {
            if (i == 0 || i == 63)
            {
                if (i == 0)
                {
                    temp = Instantiate(groundPlaneCorner, new Vector3(prevTempX.transform.position.x, 0, prevTemp.transform.position.z + 50), Quaternion.Euler(0, 180, 0));
                }

                if (i == 63)
                {
                    temp = Instantiate(groundPlaneCorner, new Vector3(prevTempX.transform.position.x, 0, prevTemp.transform.position.z + 50), Quaternion.Euler(0, 270, 0));
                }
            }

            else
            {
                temp = Instantiate(groundPlaneEdge, new Vector3(prevTempX.transform.position.x, 0, prevTemp.transform.position.z + 50), Quaternion.Euler(0, 270, 0));
            }

            currentI = i;
            prevTempX = temp;
            prevTemp = temp;
            temp.transform.parent = masterObject.transform;

            for (int j = 0; j <= 63; j++)
            {
                if (currentI == 0)
                {
                    if (currentI == 0 && j == 63)
                    {
                        temp = Instantiate(groundPlaneCorner, new Vector3(prevTemp.transform.position.x + 50, 0, prevTemp.transform.position.z), Quaternion.Euler(0, 90, 0));
                    }

                    else
                    {
                        temp = Instantiate(groundPlaneEdge, new Vector3(prevTemp.transform.position.x + 50, 0, prevTemp.transform.position.z), Quaternion.Euler(0, 180, 0));
                    }
                }

                if (currentI == 63)
                {
                    if (currentI == 63 && j == 63)
                    {
                        temp = Instantiate(groundPlaneCorner, new Vector3(prevTemp.transform.position.x + 50, 0, prevTemp.transform.position.z), Quaternion.Euler(0, 0, 0));
                    }

                    else
                    {
                        temp = Instantiate(groundPlaneEdge, new Vector3(prevTemp.transform.position.x + 50, 0, prevTemp.transform.position.z), Quaternion.Euler(0, 0, 0));
                    }
                }

                if(j == 63)
                {
                    temp = Instantiate(groundPlaneEdge, new Vector3(prevTemp.transform.position.x + 50, 0, prevTemp.transform.position.z), Quaternion.Euler(0, 90, 0));
                }


                else
                {
                    temp = Instantiate(groundPlane, new Vector3(prevTemp.transform.position.x + 50, 0, prevTemp.transform.position.z), Quaternion.identity);
                }
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
