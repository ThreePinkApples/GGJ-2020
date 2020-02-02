using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class L_ScriptDamnGoodBeanJuice : MonoBehaviour
{
    public GameObject coffee;
    GameObject player;
    Transform beanReciever;


    bool drink = false;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        //MoveBeanJuice();
       // beanReciever.transform.Find("BeanReciever");
    }

    // Update is called once per frame
    void Update()
    {
        DrinkTheBeanJuice();

        if (drink)
        {
            DrinkTheBeanJuice();
        }
        
        
    }


    public void MoveBeanJuice()
    {
        transform.parent = player.transform;
        transform.position = player.transform.position + new Vector3(1, 0.2f, 0f);

        RotateTheBeanJuice();
       
        
    }

    public void RotateTheBeanJuice()
    {
        //transform.LookAt(beanReciever);
        drink = true;
    }


    public void DrinkTheBeanJuice()
    {
        coffee.transform.position += transform.up * Time.deltaTime/3;
    }
}
