using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class B_RandomDeathSound : MonoBehaviour
{
    [SerializeField] private AudioClip[] _clips;

    // Start is called before the first frame update
    void Start()
    {
        this.GetComponent<AudioSource>().clip = _clips[Random.Range(0, _clips.Length - 1)];
        this.GetComponent<AudioSource>().Play();
    }
}
