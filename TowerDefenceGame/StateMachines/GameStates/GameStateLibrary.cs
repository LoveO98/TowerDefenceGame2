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

        public enum GameState
        {
            menu,
            runLevel,
            infoPage
        }
        public GameState _gameState;

        internal Dictionary<GameState, BaseState> StateDictionary = new Dictionary<GameState, BaseState>();

        public GameStateLibrary(GameStateMachine machine)
        {
            _gameStateMachine = machine;
            StateDictionary[GameState.menu] = new MenuState(_gameStateMachine, this);
            StateDictionary[GameState.runLevel] = new RunningLevelState(_gameStateMachine, this);
        }

        internal BaseState GetGameState(GameState state)
        {
            return StateDictionary[state];
        }



    }
}
