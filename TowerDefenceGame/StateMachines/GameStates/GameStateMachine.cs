using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static TowerDefenceGame.StateMachines.GameStates.GameStateLibrary;
using static TowerDefenceGame.StateMachines.LevelState.LevelLibrary;

namespace TowerDefenceGame.StateMachines.GameStates
{

    internal class GameStateMachine : BaseStateMachine
    {

        static internal GameStateLibrary _stateLibrary;


        public GameStateMachine()
        {
            _stateLibrary = new GameStateLibrary(this);
            _activeState = _stateLibrary.GetGameState(GameState.menu);
        }

        public override void DrawStateMachine(SpriteBatch sb)
        {
            throw new NotImplementedException();
        }

    }
}
