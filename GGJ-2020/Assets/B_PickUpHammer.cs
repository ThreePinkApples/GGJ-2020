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
            Debug.Log("Pick up");

            Destroy(this.GetComponent<Collider>());
            Destroy(this.GetComponent<Rigidbody>());

            foreach(Collider collider in this.transform.GetComponentsInChildren<Collider>())
            {
                collider.isTrigger = true;
            }

            this.transform.SetParent(_player);
            _pickUpPromptText.SetActive(false);

            this.transform.localPosition = _onPickUpPosition;
            this.transform.localRotation = Quaternion.Euler(_onPickUpRotation);

            this.enabled = false;
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
