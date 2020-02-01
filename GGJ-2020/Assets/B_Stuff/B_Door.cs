using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class B_Door : MonoBehaviour
{
    [SerializeField] private Vector3 _openRotation = new Vector3(0, 170, 0);
    [SerializeField] private float _speed = 50f;

    private Vector3 _targetRotation;
    private Vector3 _startRotation;

    private void Update()
    {
        if (Quaternion.Angle(this.transform.localRotation, Quaternion.Euler(_targetRotation)) > 0.001f)
        {
            // Target not met. Rotate more!
            this.transform.localRotation = Quaternion.RotateTowards(this.transform.localRotation, Quaternion.Euler(_targetRotation), Time.deltaTime * _speed);
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            if (!PlayerIsCloseEnough)
                return;
            else if(!PlayerHasHammer)
            {
                this.transform.parent.GetChild(1).gameObject.GetComponent<B_TellStory>().StartDialogue();
                return;
            }

            _targetRotation = _targetRotation == _openRotation ? _startRotation : _openRotation;

            this.GetComponent<AudioSource>().Play();
        }
    }

    public bool PlayerIsCloseEnough { private get; set; } = false;

    public bool PlayerHasHammer { private get; set; } = false;
}
