using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Golf
{

    public class Stone : MonoBehaviour
    {
        public static System.Action onCollisionStone;
        public bool isAfeet = false;

        private void OnCollisionEnter(Collision collision)
        {
            if(collision.transform.TryGetComponent(out Stone other))
            {
                if (!other.isAfeet) 
                {
                    onCollisionStone?.Invoke();
                }
            }
        }
    }
}