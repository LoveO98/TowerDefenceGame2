using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TowerDefenceGame.StateMachines.LevelState.Sandbox;

namespace TowerDefenceGame.StateMachines.LevelState
{
    internal class LevelLibrary : BaseStateLibrary
    {

        internal LevelStateMachine _levelStateMachine;

        public enum LevelKey
        {
            sandbox
        }

        public LevelKey levelKey;

        internal Dictionary<LevelKey, BaseState> LevelDictionary = new Dictionary<LevelKey, BaseState>();

        public LevelLibrary(LevelStateMachine machine)
        {
            _levelStateMachine = machine;
            LevelDictionary[LevelKey.sandbox] = new SandboxState(_levelStateMachine, this);
        }

        

        internal BaseState GetLevelState(LevelKey key)
        {
            return LevelDictionary[key];
        }


    }
}
