using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class L_ScriptDamnGoodCoffee : MonoBehaviour
{
    public AudioSource acidJazz;
    public GameObject player;
    private float musicVolume;


    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        
    }

    // Update is called once per frame
    void Update()
    {

        float distance = Vector3.Distance(player.transform.position, transform.position);
        //Debug.Log(distance);
        musicVolume = (100 - distance)/100;
        //Debug.Log(musicVolume);
        acidJazz.volume = musicVolume;
   
    }
}
