using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cloud : MonoBehaviour
{
    [SerializeField] private ParticleSystem m_particleSystem;

    public void FlayFX()
    {
        m_particleSystem.Play();
    }

    public void StopFX()
    {
        m_particleSystem.Stop();
    }
}
