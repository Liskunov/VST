using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Golf
{
    public class GameFinishStateFake : GameState
    {
        public GameState finish;
            public void RunFinishState()
        {
            Exit();
            finish.Enter();
        }
    }
}