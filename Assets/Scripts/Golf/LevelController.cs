using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

namespace Golf
{
    public class LevelController : MonoBehaviour
    {
        public Spawner spawner;

        public bool isGameOver = false;


        public int score = 0;



        private void Start () 
        {
            
        }

        private void OnEnable()
        {
            GameEvents.onStickHit += OnStickHit;
            score = 0;
        }

        private void OnDisable()
        {
            GameEvents.onStickHit -= OnStickHit;
        }
        private void OnStickHit()
        {
            score++;

            Debug.Log($"score: {score}");
        }

    }
}
