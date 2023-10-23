using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace Golf
{
    public class LevelController : MonoBehaviour
    {

        public GameObject player;
        public GameObject sphere;
        public GameObject startTutorial;
        public GameObject startLevel1;
        public GameObject startLevel2;
        public GameObject menuPosition;
        public GameObject level2RotateTargets;

        public TMP_Text targetsText;

        public Spawner spawner;
        public Player playerPower;

        public int targets = 0;
        public int levelN = 0;

        public List<GameObject> vaews;
        public List<GameObject> targets_Tutuorial;
        public List<GameObject> targets_Level_1;       
        public List<GameObject> targets_Level_2;
        public GameObject gameOverTargetT;
        public GameObject gameOverTarget1;
        public List<GameObject> gameOverTargets2;

        public void ButtonStart()
        {
            RunTutorial();
        }

        public void SetNoActive()
        {
            foreach (var item in vaews)
            {
                if (item)
                {
                    item.SetActive(false);
                }
            }
        }

        public void RunMenu() 
        {
            player.transform.position = menuPosition.transform.position;
            player.transform.rotation = menuPosition.transform.rotation;
            spawner.RigidBodyOff();
            sphere.transform.position = spawner.transform.position;
            SetNoActive();
        }

        public void RunTutorial()
        {
            player.transform.position = startTutorial.transform.position;
            player.transform.rotation = startTutorial.transform.rotation;
            spawner.RigidBodyOff();
            sphere.transform.position = spawner.transform.position;
            targets = 3;
            gameOverTargetT.SetActive(true);
            foreach (var item in targets_Tutuorial)
            {
                if (item)
                {
                    item.SetActive(true);
                    item.GetComponent<BoxCollider>().enabled = true;
                    item.GetComponent<Renderer>().material.color = new Vector4(0, 0.165f, 0.737f, 1.0f);
                }
            }
            
        }

        public void RunLevel_1()
        {
            player.transform.position = startLevel1.transform.position;
            player.transform.rotation = startLevel1.transform.rotation;
            spawner.RigidBodyOff();
            sphere.transform.position = spawner.transform.position;
            targets = 5;
            playerPower.power = 10;
            playerPower.RefreshPower();
            SetNoActive();
            gameOverTarget1.SetActive(true);

            foreach (var item in targets_Level_1)
            {
                if (item)
                {
                    item.SetActive(true);
                    item.GetComponent<BoxCollider>().enabled = true;
                    item.GetComponent<Renderer>().material.color = new Vector4(0, 0.165f, 0.737f, 1.0f);
                }
            }

        }

        public void RunLevel_2()
        {
            player.transform.position = startLevel2.transform.position;
            player.transform.rotation = startLevel2.transform.rotation;
            spawner.RigidBodyOff();
            sphere.transform.position = spawner.transform.position;
            targets = 4;
            playerPower.power = 10;
            playerPower.RefreshPower();
            SetNoActive();
            level2RotateTargets.SetActive(true);
            foreach (var item in targets_Level_2)
            {
                if (item)
                {
                    item.SetActive(true);
                    item.GetComponent<BoxCollider>().enabled = true;
                    item.GetComponent<Renderer>().material.color = new Vector4(0, 0.165f, 0.737f, 1.0f);
                }
            }
            foreach (var item in gameOverTargets2)
            {
                if (item)
                {
                    item.SetActive(true);
                }
            }
        }
        public void StartNextLevel()
        {
            if (levelN == 0)
            {
                RunTutorial();
            }
            if (levelN == 1) 
            {
                RunLevel_1();
                
            }

            if (levelN == 2)
            {
                RunLevel_2();
            }
            if (levelN == 3)
            {
                return;
            }

        }

        private void Update()
        {
            targetsText.text = $"Целей осталось: {targets}"; 
            if (targets == 0)
            {
                
                GameEvents.LevelComplete();
            }
        }

    }
}
