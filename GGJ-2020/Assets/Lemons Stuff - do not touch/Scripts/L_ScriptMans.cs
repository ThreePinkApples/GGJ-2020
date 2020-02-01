using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class L_ScriptMans : MonoBehaviour
{
    public GameObject leftLeg;
    public GameObject rightLeg;

    public Transform leftLegRotation;
    public Transform rightLegRotation;

    Vector3 rot = new Vector3(0, 0, 1);
    Vector3 move = new Vector3(1, 0, 0);
    int rotSpeed = 10;

    float walkSpeed = .25f;

    GameObject player;


    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }



    // Update is called once per frame
    void Update()
    {
        transform.position -= move * walkSpeed;

        leftLeg.transform.RotateAround(leftLegRotation.transform.position,rot,rotSpeed);
        rightLeg.transform.RotateAround(rightLegRotation.transform.position, rot, rotSpeed);

        //transform.rotation = Quaternion.Euler(0, Mathf.FloorToInt(Random.Range(0, 360)), 0);
        /*
        float distance = Vector3.Distance(transform.position, player.transform.position);
        if(distance > 150)
        {
            Destroy(this);
        }*/
    }
}
