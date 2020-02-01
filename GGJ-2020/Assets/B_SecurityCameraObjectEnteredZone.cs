using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[System.Serializable]
public class B_CameraDetectedPlayerEvent : UnityEvent <Transform>
{ }

public class B_SecurityCameraObjectEnteredZone : MonoBehaviour
{
    [SerializeField] private B_CameraDetectedPlayerEvent _onPlayerEnterZone = new B_CameraDetectedPlayerEvent();
    [SerializeField] private B_CameraDetectedPlayerEvent _onPlayerLeftZone = new B_CameraDetectedPlayerEvent();


    private void OnTriggerEnter(Collider collider)
    {
        Debug.Log("The fucking player entered mah zone!");

        _onPlayerEnterZone.Invoke(collider.transform);
    }

    private void OnTriggerExit(Collider collider)
    {
        Debug.Log("The fucking player entered mah zone!");

        _onPlayerLeftZone.Invoke(collider.transform);
    }
}
