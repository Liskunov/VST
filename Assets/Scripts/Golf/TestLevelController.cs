using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestLevelController : MonoBehaviour
{
    [SerializeField] Camera m_mainCamera;
    [SerializeField] Transform m_transform;
    public void LoadNextLevel()
    {
        m_mainCamera.transform.position = m_transform.position;
    }
}
