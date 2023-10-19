using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Golf
{

    public class Stone : MonoBehaviour
    {


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
            }
        }
    }
}