using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Golf
{
    
    public class Rotation : MonoBehaviour
    {
        private bool l_isDown = false;
        private bool r_isDown = false;
        public void LeftRotat(bool volue)
        {
            l_isDown = volue;
            transform.Rotate(0, -1, 0);
        }

        public void RightRotat(bool volue)
        {
            r_isDown = volue;
            transform.Rotate(0, 1, 0);
        }


    }
}