using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;

namespace Golf
{
    public class Player : MonoBehaviour
    {
        public Transform stick;
        public Transform helper;
        public Transform pricel;
        public float range = 30;
        public float speed = 500f;
        public float power = 20f;
       

        private bool m_isDown = false;

        private void Update()
        {

            Quaternion rot = stick.localRotation;
            Quaternion toRot = Quaternion.Euler(0,0, m_isDown ? -20 :  range);

            stick.localRotation = Quaternion.RotateTowards(rot, toRot, speed *  Time.deltaTime);

        }

        public void SetDown(bool value)
        {
            m_isDown = value;
        }

        public void OnCollisionStick(Collider collider)
        {
            if (collider.TryGetComponent(out Rigidbody body))
            {
                
                var dir = (pricel.position - helper.position).normalized;
                body.AddForce(dir * power, ForceMode.Impulse);  

                if (TryGetComponent(out Stone stone)) 
                {
                    GameEvents.StickHit();
                }
            }
        }
    }
}