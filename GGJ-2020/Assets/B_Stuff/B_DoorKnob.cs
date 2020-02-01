using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class B_DoorKnob : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        this.GetComponentInParent<B_Door>().PlayerIsCloseEnough = true;
        this.transform.GetChild(0).gameObject.SetActive(true);
    }

    private void OnTriggerExit(Collider other)
    {
        this.GetComponentInParent<B_Door>().PlayerIsCloseEnough = false;
        this.transform.GetChild(0).gameObject.SetActive(false);
    }
}
