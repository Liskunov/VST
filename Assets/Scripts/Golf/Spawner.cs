using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Golf
{

    public class Spawner : MonoBehaviour
    {
        
        public GameObject prefab;
        [SerializeField]private float dilayToStoneRespawn;
        [SerializeField] private GameObject spot;

        public double time;

        public void RigidBodyOff()
        {
            spot.GetComponent<Rigidbody>().useGravity = false;
            spot.GetComponent<Rigidbody>().isKinematic = true;
            spot.GetComponent<Rigidbody>().isKinematic = false;
        }

        
        private void Start()
        {
            RigidBodyOff();      
        }

        private void Update()
        {
            
            if (spot.transform.position != transform.position)
            {
                time += Time.deltaTime;
                if (time > dilayToStoneRespawn)
                {
                    RigidBodyOff();
                    spot.transform.position = transform.position;
                    time= 0;
                }
            }

        }

    }
}
