using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Golf
{
    public class GameOverState : GameState
    {
        public GameState gamePlayState;

        public void Restart()
        {
            Exit();
            gamePlayState.Exit();
        }
    }
}
