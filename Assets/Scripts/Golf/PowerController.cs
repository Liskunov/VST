using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Golf
{
    public class PowerController : MonoBehaviour
    {
        [SerializeField] private float m_minPowerValue;
        [SerializeField] private float m_maxPowerValue;
        [SerializeField] private bool m_isPressed;
        private float m_powerValue;
        private int m_powerDir;

        private void Start()
        {
            m_powerValue = 0.0f;
        }

        private void Update()
        {          
        
            if (m_isPressed)
            {
                if (m_powerValue >= m_maxPowerValue)
                {
                    m_powerDir = -1;
                }
                else if (m_powerValue <= m_minPowerValue)
                {
                    m_powerDir = 1;
                }
                m_powerValue += 0.01f * m_powerDir;
            }
        }
    }
}