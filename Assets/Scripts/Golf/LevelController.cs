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

        private void Start () 
        {
            StartCoroutine(SpawnStoneProc());
        }

        private IEnumerator SpawnStoneProc()
        {
            
            do
            {
                yield return new WaitForSeconds(delay);
            }
            while (!isGameOver);
        }
    }
}
