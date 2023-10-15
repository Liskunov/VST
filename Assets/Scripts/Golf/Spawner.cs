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

        private double time;
        private void Start()
        {
            prefab.GetComponent<Rigidbody>().isKinematic = true;

            Instantiate(prefab, transform.position, Quaternion.identity);
        }

        private void Update()
        {

            if (prefab.transform.position != transform.position)
            {
                time += Time.deltaTime;
                Debug.Log(time);
                if (time > dilayToStoneRespawn)
                {
                    prefab.transform.position = transform.position;
                    time= 0;
                }
            }

        }

    }
}
