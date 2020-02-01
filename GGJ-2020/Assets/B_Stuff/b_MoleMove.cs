using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class b_MoleMove : MonoBehaviour
{
    [SerializeField] Vector2 xBorder;
    [SerializeField] Vector2 zBorder;

    private Vector3 _target;

    [SerializeField] private float _speed = 100f;

    // Start is called before the first frame update
    void Start()
    {
        _target = GenerateTarget();
    }

    // Update is called once per frame
    void Update()
    {
        if(Vector3.Distance(this.transform.position, _target) <= 0.001f)
        {
            // Target reached. Find new point.
            _target = GenerateTarget();
        }

        this.transform.position = Vector3.MoveTowards(this.transform.position, _target, Time.deltaTime * _speed);
    }

    private Vector3 GenerateTarget()
    {
        float x = Random.Range(xBorder.x, xBorder.y);
        float z = Random.Range(zBorder.x, zBorder.y);

        return new Vector3(x, this.transform.position.y, z);
    }

    private void OnTriggerEnter(Collider other)
    {
        this.enabled = false;
    }
}
