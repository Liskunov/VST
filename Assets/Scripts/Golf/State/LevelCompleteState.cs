using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Golf
{
    public class LevelCompliteState : GameState
    {
        public GameState gamePlayState;
        public GameState gameFinishStateFake;
        public LevelController levelController;

        public void NextLevel()
        {
            if (levelController.levelN < 3)
            {
                Exit();
                gamePlayState.Enter();
            }
            else
            {
                Exit();
                gameFinishStateFake.Enter();
            }
        }
    }
}