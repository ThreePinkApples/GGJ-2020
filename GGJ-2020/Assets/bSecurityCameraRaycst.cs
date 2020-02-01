using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bSecurityCameraRaycst : MonoBehaviour
{

    [SerializeField] private float _cameraDistance = 10f;
    private Transform _playerTransform = null;

    [Header("Ground Marker")]
    [SerializeField] private Transform _groundMarker;

    [SerializeField] private LayerMask _mask;

    // Update is called once per frame
    void Update()
    {
        Ray groundRay = new Ray(this.transform.position, this.transform.forward);
        RaycastHit hit;

        Debug.DrawRay(this.transform.position, this.transform.forward * _cameraDistance, Color.green);

        if(Physics.Raycast(groundRay, out hit, _cameraDistance, _mask))
        {
            _groundMarker.position = hit.point;
        }
    }
}
