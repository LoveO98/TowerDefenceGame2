using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TowerDefenceGame.StateMachines.LevelState;

namespace TowerDefenceGame.StateMachines
{

    internal abstract class BaseState
    {

        protected BaseStateMachine _stateMachine;
        protected BaseStateLibrary _library;

        public BaseState(BaseStateMachine machine, BaseStateLibrary library)
        {
            _stateMachine = machine;
            _library = library;
        }

        public abstract void EnterState();

        public abstract void ExitState();

        public abstract void UpdateState(GameTime gameTime);

        //public abstract void DrawState(SpriteBatch sb);

        public abstract void CheckSwitchState();

        public void SwitchState(BaseState newState)
        {
            ExitState();
            newState.EnterState();
            _stateMachine._activeState = newState;
        }
    }
}
