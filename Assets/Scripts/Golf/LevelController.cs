using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace Golf
{
    public class LevelController : MonoBehaviour
    {

        public GameObject player;
        public GameObject startTutorial;
        public GameObject start1Level;
        public GameObject menuPosition;

        public TMP_Text targetsText;

        public int targets = 0;
        public int levelN = 0;

        public List<GameObject> vaews;
        public List<GameObject> targets_Tutuorial;
        public List<GameObject> targets_Level_1;       

        public void ButtonStart()
        {
            RunTutorial();
            player.transform.position = startTutorial.transform.position;
            player.transform.rotation = startTutorial.transform.rotation;
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

            SetNoActive();
        }

        public void RunTutorial()
        {
            targets = 3;
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
            player.transform.position = start1Level.transform.position;
            player.transform.rotation = start1Level.transform.rotation;
            targets = 5;
            SetNoActive();
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
