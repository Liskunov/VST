using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.WSA;

namespace Golf
{
    public class Stick : MonoBehaviour
    {

        public UnityEvent<Collider> onCollision;

        private void OnCollisionEnter(Collision collision)
        {
            onCollision.Invoke(collision.collider);
        }
    
    }

}