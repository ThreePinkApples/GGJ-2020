using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class L_ScriptRandomizeBuildings : MonoBehaviour
{

    void Start()
    {
        transform.localScale = new Vector3(1.75f, Mathf.RoundToInt(Random.Range(3,5)), 1.75f);       
    }

}
