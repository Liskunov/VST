using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Golf
{
    public class LevelCompliteState : GameState
    {
        public GameState gamePlayState;
        public LevelController levelController;

        public void NextLevel()
        {
            levelController.levelN++;
            Exit();
            gamePlayState.Exit();
        }
    }
}