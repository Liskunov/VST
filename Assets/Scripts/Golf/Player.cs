using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;
using TMPro;

namespace Golf
{
    public class Player : MonoBehaviour
    {
        public Transform stick;
        public Transform helper;
        public Transform pricel;
        public float range = 30;
        public float speed = 500f;
        public float power = 5f;
        public TMP_Text powerText;

        private void Awake()
        {
            powerText.text = $"Power : {power}";
        }


        private bool m_isDown = false;

        private void Update()
        {

            Quaternion rot = stick.localRotation;
            Quaternion toRot = Quaternion.Euler(0,0, m_isDown ? -20 :  range);

            stick.localRotation = Quaternion.RotateTowards(rot, toRot, speed *  Time.fixedDeltaTime);

            
        }

        public void SetDown(bool value)
        {
            m_isDown = value;
        }

        public void PowerUp()
        {
            power = power + 1.0f;
            powerText.text = $"Power : {power}";
        }

        public void PowerDown()
        {
            power = power - 1.0f;
            powerText.text = $"Power : {power}";
        }

        public void OnCollisionStick(Collider collider)
        {
            if (collider.TryGetComponent(out Rigidbody body))
            {                
                var dir = (pricel.position - helper.position).normalized;
                body.AddForce(dir * power, ForceMode.Impulse);  
            }
        }
    }
}