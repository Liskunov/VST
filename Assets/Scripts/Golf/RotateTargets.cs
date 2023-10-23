using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Golf
{
    public class RotateTargets : MonoBehaviour
    {
        void Update()
        {
            transform.Rotate (0, 0.1f, 0);
        }
    }
}
