using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Golf
{
    public class PlayerController : MonoBehaviour
    {
        [SerializeField] private Player player;
        [SerializeField] private Rotation rotation;

        public void OnDown()
        {
            player.SetDown(true);
        }

        public void OnUp()
        {
            player.SetDown(false);
        }

        public void LeftUp()
        {
            rotation.LeftRotat(false);
        }

        public void LeftDown()
        {
            rotation.LeftRotat(true);
        }

        public void RightUp() 
        {
            rotation.RightRotat(false);
        }

        public void RightDown()
        {
            rotation.RightRotat(true);
        }
    }
}
