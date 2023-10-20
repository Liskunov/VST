using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

namespace Golf
{
    public class LevelController : MonoBehaviour
    {
        public Spawner spawner;
        public GameObject player;
        public GameObject startPosition;
        public GameObject menuPosition;

        public bool isGameOver = false;


        public int score = 0;

        public List<GameObject> vaews;
        public List<GameObject> targets_Tutuorial_Part1;
        public List<GameObject> targets_Tutuorial_Part2;
        public List<GameObject> targets_Tutuorial_Part3;
        public List<GameObject> targets_Level_1;


        public void ButtonStart()
        {
            TutorialPart1();
            player.transform.position = startPosition.transform.position;
            player.transform.rotation = startPosition.transform.rotation;
        }
        public void Menu() 
        {
            player.transform.position = menuPosition.transform.position;
            player.transform.rotation = menuPosition.transform.rotation;

            foreach (var item in vaews)
            {
                if (item)
                {
                    item.SetActive(false);
                }
            }
        }

        public void TutorialPart1()
        {
            foreach (var item in targets_Tutuorial_Part1)
            {
                if (item)
                {
                    item.SetActive(true);
                    item.GetComponent<BoxCollider>().enabled = true;
                }
            }
        }

        public void TutorialPart2()
        {
            foreach (var item in targets_Tutuorial_Part2)
            {
                if (item)
                {
                    item.SetActive(true);
                    item.GetComponent<BoxCollider>().enabled = true;
                }
            }
        }

        public void TutorialPart3()
        {
            foreach (var item in targets_Tutuorial_Part3)
            {
                if (item)
                {
                    item.SetActive(true);
                    item.GetComponent<BoxCollider>().enabled = true;
                }
            }
        }

        public void Level_1()
        {
            Menu();
            foreach (var item in targets_Level_1)
            {
                if (item)
                {
                    item.SetActive(true);
                    item.GetComponent<BoxCollider>().enabled = true;
                }
            }

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
