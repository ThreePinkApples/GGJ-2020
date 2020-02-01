using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class B_SecurityCameraRotator : MonoBehaviour
{
    private Transform _playerTransform = null;

    private bool _movingLeft = true;

    [SerializeField] private Vector3 _targetOne = new Vector3();
    [SerializeField] private Vector3 _targetTwo = new Vector3();

    [SerializeField] private float _speed = 0.1f;

    private void Update()
    {
        if(_playerTransform == null)
        {
            // Can't see the player. Rotate randomly.
            if (_movingLeft)
            {
                this.transform.rotation = Quaternion.RotateTowards(this.transform.rotation, Quaternion.Euler(_targetOne), Time.deltaTime * _speed);

                if (Quaternion.Angle(Quaternion.Euler(_targetOne), this.transform.rotation) <= 0.01f)
                {
                    _movingLeft = false;
                }
            }
            else
            {
                this.transform.rotation = Quaternion.RotateTowards(this.transform.rotation, Quaternion.Euler(_targetTwo), Time.deltaTime * _speed);

                if (Quaternion.Angle(Quaternion.Euler(_targetTwo), this.transform.rotation) <= 0.01f)
                {
                    _movingLeft = true;
                }
            }
        }
        else
        {
            // Player spotted! Look at the player until it leaves the camera view.
        }
    }

    public void SetPlayerTarget(Transform player)
    {
        _playerTransform = player;
    }

    public void RemovePlayerTarget()
    {
        _playerTransform = null;
    }
}
