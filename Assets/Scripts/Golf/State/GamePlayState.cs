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
        public GameState gameOverState;

        protected override void OnEnable()
        {
            base.OnEnable();
            GameEvents.onStickHit += OnStickHit;
            GameEvents.onLevelComplete += OnLevelComplete;
            GameEvents.onGameOver += OnGameOver;
        }

        private void OnStickHit()
        {
            targetText.text = $"Целей осталось: {levelController.targets}";
        }
        private void OnLevelComplete()
        {
            levelController.levelN++;
            Exit();
            levelCompleteState.Enter();
        }

        private void OnGameOver()
        {
            Exit();
            gameOverState.Enter();
        }
        protected override void OnDisable()
        {
            base.OnDisable();
            GameEvents.onStickHit -= OnStickHit;
            GameEvents.onLevelComplete -= OnLevelComplete;
            GameEvents.onGameOver -= OnGameOver;
        }
    }
}