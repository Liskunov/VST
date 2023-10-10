using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Golf
{
    public class Stick : MonoBehaviour
    {
        public UnityEvent<Collider> onColision;
        private void OnCollisionEnter(Collision collision)
        {
            
        }
    }
}