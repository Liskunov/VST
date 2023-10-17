using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Golf
{

    public class Stone : MonoBehaviour
    {


        private void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.tag == "palka")
            {
                GetComponent<Rigidbody>().useGravity = true;
            }
        }
    }
}