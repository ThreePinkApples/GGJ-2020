using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace UnityStandardAssets.Characters.FirstPerson
{
    public class L_ScriptTriggerEndgame : MonoBehaviour
    {
        public bool endIsNear = false;
        public Collider endTrigger;

        public GameObject beanJuiceText;

        public L_ScriptDamnGoodBeanJuice beanJuiceScript;
        public L_ScriptChangeMusic musicScript;
        // Start is called before the first frame update
        void Start()
        {
            beanJuiceScript = GameObject.Find("Cup").GetComponent<L_ScriptDamnGoodBeanJuice>();
            musicScript = GameObject.FindGameObjectWithTag("Player").GetComponent<L_ScriptChangeMusic>();

        }

        // Update is called once per frame
        void Update()
        {

        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.tag == "Player")
            {
                musicScript.ChangeMusic();
                RigidbodyFirstPersonController.endIsNear = true;
                beanJuiceScript.MoveBeanJuice();
                beanJuiceText.SetActive(true);

                
            }
        }
    }

}

