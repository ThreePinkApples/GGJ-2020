using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class L_ScriptWorldRender : MonoBehaviour
{
    public GameObject player;
    public GameObject plane;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(player.transform.position, transform.position);
        if (distance > 100)
        {
            plane.SetActive(false);
        }

        else
        {
            plane.SetActive(true);
        }
        
    }
}
