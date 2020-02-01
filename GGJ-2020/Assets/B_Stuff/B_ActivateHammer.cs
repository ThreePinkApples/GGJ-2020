using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class B_ActivateHammer : MonoBehaviour
{
    [SerializeField] private GameObject _hammer;

    public void Activate()
    {
        _hammer.SetActive(true);
    }
}
