using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class B_UseHammer : MonoBehaviour
{
    private enum Hammer
    {
        down,
        up,
        idle
    }

    private Hammer hammer = Hammer.idle;

    [SerializeField] private Vector3 _originalRotation;
    [SerializeField] private Vector3 _downRotation;

    [SerializeField] private float _speed = 1500f;


    public float _caIntensity;
    public float _caSpeed;
    public float _caPause;

    public float _vIntensity;
    public float _vSpeed;
    public float _vPause;

    // Update is called once per frame
    void Update()
    {
        if(hammer == Hammer.idle)
        {
            if (Input.GetMouseButton(0))
            {
                hammer = Hammer.down;
                foreach (Collider collider in this.transform.GetChild(0).GetComponentsInChildren<Collider>())
                {
                    collider.enabled = true;
                }
            }
        }
        else if (hammer == Hammer.down)
        {
            // Animate down
            AnimateDown();
        }
        else
        {
            // Animate up
            AnimateUp();
        }
    }

    private void AnimateDown()
    {
        this.transform.localRotation = Quaternion.RotateTowards(this.transform.localRotation, Quaternion.Euler(_downRotation), Time.deltaTime * _speed);

        //if (this.transform.localEulerAngles.x - _downRotation.x <= 0.01f)
        if(Quaternion.Angle(this.transform.localRotation, Quaternion.Euler(_downRotation)) <= 0.01f)
        {
            // Rotation over
            hammer = Hammer.up;
            foreach (Collider collider in this.transform.GetComponentsInChildren<Collider>())
            {
                collider.enabled = false;
            }
        }
    }

    private void AnimateUp()
    {

        this.transform.localRotation = Quaternion.RotateTowards(this.transform.localRotation, Quaternion.Euler(_originalRotation), Time.deltaTime * _speed);

        if (Quaternion.Angle(this.transform.localRotation, Quaternion.Euler(_originalRotation)) <= 0.01f)
        {
            hammer = Hammer.idle;
        }
    }

    public void HammerHit(GameObject other)
    {
        Debug.Log("Hammer hit!");

        if(other.GetComponent<L_ScriptMans>())
        {
            other.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
            other.GetComponent<L_ScriptMans>().Kill();
        }

        GameObject.FindObjectOfType<B_PlayOneShotChromaticAberation>().PlayOneShot(_caIntensity, _caSpeed, _caPause);
    }
}
