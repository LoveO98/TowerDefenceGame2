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

        public StateKey _levelKey;

        

        public LevelLibrary(LevelStateMachine machine)
        {
            StateDictionary = new Dictionary<StateKey, BaseState>();
            _levelStateMachine = machine;
            StateDictionary[StateKey.sandbox] = new SandboxState(_levelStateMachine, this);
            StateDictionary[StateKey.level1] = new Level1State(_levelStateMachine, this);
            StateDictionary[StateKey.level2] = new Level2State(_levelStateMachine, this);
            StateDictionary[StateKey.stressTest] = new StressTestState(_levelStateMachine, this);
        }

    }
}
