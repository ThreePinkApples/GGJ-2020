using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class B_HammerCollider : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        this.transform.parent.parent.GetComponent<B_UseHammer>().HammerHit(other.gameObject);
    }
}
