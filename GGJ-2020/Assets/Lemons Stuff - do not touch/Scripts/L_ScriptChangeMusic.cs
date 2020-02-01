using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class L_ScriptChangeMusic : MonoBehaviour
{
    public AudioClip acidJazz;
    public AudioClip jazzBonanza;

    public AudioSource audioS;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    
        
    }

    public void ChangeMusic()
    {
        audioS.clip = jazzBonanza;
        audioS.Play();
    }
}
