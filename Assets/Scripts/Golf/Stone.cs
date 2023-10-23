using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Golf
{

    public class Stone : MonoBehaviour
    {
        public LevelController controller;
        public Spawner spawner;


        private void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.CompareTag("palka"))
            {
                GetComponent<Rigidbody>().useGravity = true;
            }

            if (collision.gameObject.CompareTag("TargetCube"))
            {
                collision.gameObject.GetComponent<Renderer>().material.color = new Vector4(0, 0, 0, 0.5f);
                collision.gameObject.GetComponent<BoxCollider>().enabled = false;
                controller.targets--;
                spawner.RigidBodyOff();
                transform.position = spawner.transform.position;
                spawner.time = 0;
            }

            if (collision.gameObject.CompareTag("GameOver"))
            {
                GameEvents.GameOver();
            }

        }
    }
}