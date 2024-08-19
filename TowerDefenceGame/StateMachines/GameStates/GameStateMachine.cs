using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static TowerDefenceGame.StateMachines.BaseStateLibrary;

namespace TowerDefenceGame.StateMachines.GameStates
{

    internal class GameStateMachine : BaseStateMachine
    {
        public BaseStateLibrary _stateLibrary;
        

        public GameStateMachine()
        {
            _stateLibrary = new GameStateLibrary(this);
            _activeState = _stateLibrary.GetState(StateKey.menu);
            _activeState.EnterState();
        }
    }
}
