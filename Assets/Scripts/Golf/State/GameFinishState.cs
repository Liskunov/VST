using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Golf
{
    public class GameFinishState : GameState
    {
        public GameState mainMenuState;

        public void BackToMenu()
        {
            Exit();
            mainMenuState.Enter();
        }

    }
}
