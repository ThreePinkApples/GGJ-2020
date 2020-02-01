using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class B_TrapDoor : MonoBehaviour
{
    public Vector3 _targetRotation;

    [SerializeField] private float _speed = 50f;

    private bool _doOpen = false;

    private void Update()
    {
        if (!_doOpen)
            return;

        if (Quaternion.Angle(this.transform.rotation, Quaternion.Euler(_targetRotation)) > 0.001f)
        {
            // Target not met. Rotate more!
            this.transform.rotation = Quaternion.RotateTowards(this.transform.rotation, Quaternion.Euler(_targetRotation), Time.deltaTime * _speed);
            //float newY = Mathf.MoveTowards(this.transform.eulerAngles.y, _targetRotation.y, Time.deltaTime * _speed);
            //this.transform.rotation = Quaternion.Euler(this.transform.eulerAngles.x, newY, this.transform.eulerAngles.z);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        _doOpen = true;
        this.GetComponent<AudioSource>().Play();
    }
}