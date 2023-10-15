using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Golf
{
    public abstract class GameState : MonoBehaviour
    {
        public List<GameObject> vaews;

        public virtual void Enter()
        {
            gameObject.SetActive(true);
        }

        public virtual void Exit() 
        {
            gameObject.SetActive(false);
        }
        private void OnEnable()
        {
            foreach (var item  in vaews) 
            {
                item.SetActive(true);
            }
        }

        private void OnDisable() 
        {
            foreach (var item in vaews)
            {
                item.SetActive(false); 
            }
            
        }
    }
}