using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class B_LookAtPlayer : MonoBehaviour
{
    private Transform _player = null;

    private void Start()
    {
        _player = GameObject.Find("RigidBodyFPSController (1)").transform;
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.LookAt(_player);
    }
}
