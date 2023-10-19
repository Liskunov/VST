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
            rotation.LeftRotate(false);
        }

        public void LeftDown()
        {
            rotation.LeftRotate(true);
        }

        public void RightUp() 
        {
            rotation.RightRotate(false);
        }

        public void RightDown()
        {
            rotation.RightRotate(true);
        }
    }
}
