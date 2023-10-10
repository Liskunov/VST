using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Golf
{
    public class LevelController : MonoBehaviour
    {
        public Spawner spawner;
        public bool isGameOver = false;
        public float delay = 0.5f;
        public float m_lastSpawnedTime = 0;
        

        private void Start () 
        {
            //StartCoroutine(SpawnStoneProc());
            m_lastSpawnedTime = Time.time;
        }

        private void Update()
        {
            if (!isGameOver)
            {
                if (Time.time m_lastSpawnedTime)
            }
        }
        private IEnumerator SpawnStoneProc()
        {
            
            do
            {
                yield return new WaitForSeconds(delay);

                spawner.Spawn();
            }
            while (!isGameOver);
        }
    }
}
