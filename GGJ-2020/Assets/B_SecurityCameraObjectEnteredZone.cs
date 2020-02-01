using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class B_SecurityCameraObjectEnteredZone : MonoBehaviour
{
    [SerializeField] private UnityEvent _onPlayerEnterZone = new UnityEvent();
    [SerializeField] private UnityEvent _onPlayerLeftZone = new UnityEvent();


    private void OnTriggerEnter(Collider collider)
    {
        Debug.Log("The fucking player entered mah zone!");

        _onPlayerEnterZone.Invoke();
    }

    private void OnTriggerExit(Collider collider)
    {
        Debug.Log("The fucking player entered mah zone!");

        _onPlayerLeftZone.Invoke();
    }

}
