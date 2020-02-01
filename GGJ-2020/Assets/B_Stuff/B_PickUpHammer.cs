using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class B_PickUpHammer : MonoBehaviour
{
    [SerializeField] private GameObject _pickUpPromptText;

    private Transform _player = null;

    [SerializeField] private Vector3 _onPickUpPosition;
    [SerializeField] private Vector3 _onPickUpRotation;

    // Update is called once per frame
    void Update()
    {
        if(_player && Input.GetKeyDown(KeyCode.E))
        {
            GameObject.FindObjectOfType<B_ActivateHammer>().Activate();
            GameObject.FindObjectOfType<B_Door>().PlayerHasHammer = true;
            Destroy(this.gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "Player")
        {
            _player = other.transform;
            _pickUpPromptText.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.transform.tag == "Player")
        {
            _player = null;
            _pickUpPromptText.SetActive(false);
        }
    }
}
