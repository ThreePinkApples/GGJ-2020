using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class L_ScriptMans : MonoBehaviour
{
    public GameObject leftLeg;
    public GameObject rightLeg;

    public Transform leftLegRotation;
    public Transform rightLegRotation;

    Vector3 rot = new Vector3(0, 0, 1);
    Vector3 move = new Vector3(1, 0, 0);
    int rotSpeed = 10;

    public float walkSpeed = .25f;

    GameObject player;

    private bool _isDead = false;


    Vector2 randomThreshold = new Vector2(2, 10);
    float timeLeftUntilDirectionIsChanged = 0;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");

        this.transform.localRotation = Quaternion.Euler(0, Random.Range(0, 360), 0);
        timeLeftUntilDirectionIsChanged = Random.Range(randomThreshold.x, randomThreshold.y);

        StartCoroutine(CommitSilentSudoku());
    }

    public void Kill()
    {
        _isDead = true;

        StartCoroutine(CommitSudoku());
    }

    private IEnumerator CommitSudoku()
    {
        yield return new WaitForSeconds(15);

        Destroy(this.gameObject);
    }

    private IEnumerator CommitSilentSudoku()
    {
        yield return new WaitForSeconds(180);

        Destroy(this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        if (!_isDead)
        {
            transform.position -= this.transform.forward * walkSpeed;

            timeLeftUntilDirectionIsChanged -= Time.deltaTime;

            if(timeLeftUntilDirectionIsChanged <= 0)
            {
                timeLeftUntilDirectionIsChanged = Random.Range(randomThreshold.x, randomThreshold.y);
                this.transform.localRotation = Quaternion.Euler(0, Random.Range(0, 360), 0);
            }
        }
        leftLeg.transform.RotateAround(leftLegRotation.transform.position,rot,rotSpeed);
        rightLeg.transform.RotateAround(rightLegRotation.transform.position, rot, rotSpeed);

        //transform.rotation = Quaternion.Euler(0, Mathf.FloorToInt(Random.Range(0, 360)), 0);
        /*
        float distance = Vector3.Distance(transform.position, player.transform.position);
        if(distance > 150)
        {
            Destroy(this);
        }*/
    }
}
