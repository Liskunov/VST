using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Golf
{
    public class LevelController : MonoBehaviour
    {
        public Spawner spawner;
        public float m_lastSpawnedTime = 0;
        public bool isGameOver = false;
        public float m_delay = 0.5f;
        public float delayMax = 2f;
        public float delayMin = 0.5f;
        public float delayStep = 0.1f;
        
        

        private void Start () 
        {
            m_lastSpawnedTime = Time.time;
        }

        private void OnEnable()
        {
            Stone.onCollisionStone += GameOver;
        }

        private void OnDisable()
        {
            Stone.onCollisionStone -= GameOver;
        }
        private void GameOver()
        {
            Debug.Log("!!! GAME OVER !!!");
            enabled = false;
        }
        private void Update()
        {
            if (Time.time >= m_lastSpawnedTime + m_delay)
                    {
                        spawner.Spawn();
                        m_lastSpawnedTime = Time.time;

                        RefreshDelay();
            }
        }
        public void RefreshDelay()
        {
            m_delay = UnityEngine.Random.Range(delayMin, delayMax);
            delayMax = Mathf.Max(delayMin, delayMax - delayStep);
        }
    }
}
