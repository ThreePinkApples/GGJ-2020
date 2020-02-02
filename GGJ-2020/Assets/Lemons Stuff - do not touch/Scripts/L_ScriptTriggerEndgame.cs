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

        public GameObject enderMans;
        // Start is called before the first frame update
        void Start()
        {
            beanJuiceScript = GameObject.FindObjectOfType<L_ScriptDamnGoodBeanJuice>();
            musicScript = GameObject.FindObjectOfType<L_ScriptChangeMusic>();

        }

        // Update is called once per frame
        void Update()
        {

        }

        private void OnTriggerEnter(Collider other)
        {
            //if (other.gameObject.tag == "Player")
            //{
                musicScript.ChangeMusic();
                RigidbodyFirstPersonController.endIsNear = true;
                beanJuiceScript.MoveBeanJuice();
                if (!beanJuiceText.activeSelf)
                {
                    beanJuiceText.SetActive(true);
                }

                enderMans.SetActive(true);

                
            //}
        }
    }

}

