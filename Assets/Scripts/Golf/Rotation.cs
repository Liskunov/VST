using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Golf
{
    
    public class Rotation : MonoBehaviour
    {
        private Vector3 m_LeftRotate;
        private Vector3 m_RightRotate;
        private bool m_needRightRotate;
        private bool m_needLeftRotate;

        private void Start()
        {
            m_LeftRotate = new Vector3(0, -1, 0);
            m_RightRotate = new Vector3(0, 1, 0);
            m_needLeftRotate = false;
            m_needRightRotate = false;
        }
        

        public void LeftRotate(bool value)
        {
            m_needLeftRotate = value;
            Debug.Log("LeftRotate");
        }

        public void RightRotate(bool value)
        {
            m_needRightRotate = value;
            Debug.Log($"RightRotate {value}");

        }
        private void FixedUpdate()
        {
            if(m_needLeftRotate) 
            {
                transform.Rotate(m_LeftRotate);
            }

            if(m_needRightRotate)
            {
                transform.Rotate(m_RightRotate);
            }
        }

    }
}