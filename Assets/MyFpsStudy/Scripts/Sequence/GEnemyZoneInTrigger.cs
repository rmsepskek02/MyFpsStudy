using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MyFps
{

    public class GEnemyZoneInTrigger : MonoBehaviour
    {
        public Transform gunMan;
        public GameObject enemyZoneOut;
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.tag == "Player")
            {
                if (gunMan != null)
                    gunMan.GetComponent<GunEnemy>().SetState(EnemyState.E_Chase);
            }
        }

        private void OnTriggerExit(Collider other)
        {
            if (other.tag == "Player")
            {
                this.gameObject.SetActive(false);
                enemyZoneOut.SetActive(true);
            }
        }
    }
}
