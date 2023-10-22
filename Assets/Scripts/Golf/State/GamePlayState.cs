using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace Golf
{
    public class GamePlayState : GameState
    {

        public TMP_Text targetText;
        public GameState levelCompleteState;
        public LevelController levelController;

        protected override void OnEnable()
        {
            base.OnEnable();
            GameEvents.onStickHit += OnStickHit;
            GameEvents.onLevelComplete += OnLevelComplete;
        }

        private void OnStickHit()
        {
            targetText.text = $"Целей осталось: {levelController.targets}";
        }
        private void OnLevelComplete()
        {
            Exit();
            levelCompleteState.Enter();
        }
        protected override void OnDisable()
        {
            base.OnDisable();
            GameEvents.onStickHit -= OnStickHit;
            GameEvents.onLevelComplete -= OnLevelComplete;
        }
    }
}