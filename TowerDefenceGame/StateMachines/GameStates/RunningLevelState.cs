using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using TowerDefenceGame.StateMachines.LevelState;
using static TowerDefenceGame.StateMachines.BaseStateLibrary;

namespace TowerDefenceGame.StateMachines.GameStates
{
    internal class RunningLevelState : BaseState
    {

        public LevelStateMachine _levelStateMachine;

        public RunningLevelState(GameStateMachine machine, GameStateLibrary library) : base(machine, library)
        {

        }

        public override void EnterState()
        {
            _levelStateMachine._baseMenuForm.exitLevel += OnExitPressed;
            _levelStateMachine._youWonForm.returnToMenu += OnExitPressed;
            _levelStateMachine._youLostForm.returnToMenu += OnExitPressed;
            _levelStateMachine.InitializeLevelMachine(_library._selectedLevel);
        }

        public override void ExitState()
        {
            _levelStateMachine.ExitMachine();
            _levelStateMachine._baseMenuForm.exitLevel -= OnExitPressed;
            _levelStateMachine._youWonForm.returnToMenu -= OnExitPressed;
            _levelStateMachine._youLostForm.returnToMenu -= OnExitPressed;
        }

        public override void UpdateState(GameTime gameTime)
        {
            _levelStateMachine.UpdateStateMachine(gameTime);
        }

        public void OnExitPressed()
        {
            SwitchState(_library.GetState(StateKey.menu));
        }

        public override void DrawState(SpriteBatch sb)
        {
            _levelStateMachine.DrawStateMachine(sb);
        }

    }
}
