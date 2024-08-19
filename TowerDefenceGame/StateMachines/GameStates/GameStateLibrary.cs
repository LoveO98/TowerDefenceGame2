using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TowerDefenceGame.StateMachines.LevelState.Sandbox;
using TowerDefenceGame.StateMachines.LevelState;
using static TowerDefenceGame.StateMachines.LevelState.LevelLibrary;

namespace TowerDefenceGame.StateMachines.GameStates
{
    internal class GameStateLibrary : BaseStateLibrary
    {
        internal GameStateMachine _gameStateMachine;

        

        public StateKey _gameStateKey;
        

        public GameStateLibrary(GameStateMachine machine)
        {
            StateDictionary = new Dictionary<StateKey, BaseState>();
            _gameStateMachine = machine;
            StateDictionary[StateKey.menu] = new MenuState(_gameStateMachine, this);
            StateDictionary[StateKey.runLevel] = new RunningLevelState(_gameStateMachine, this);
        }

        


    }
}
