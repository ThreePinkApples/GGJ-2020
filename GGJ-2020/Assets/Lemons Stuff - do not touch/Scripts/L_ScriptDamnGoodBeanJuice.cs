using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class L_ScriptDamnGoodBeanJuice : MonoBehaviour
{
    public GameObject coffee;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        coffee.transform.position += transform.up * .010f;
        
    }
}
