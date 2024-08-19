using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TowerDefenceGame.StateMachines
{
    internal abstract class BaseStateLibrary
    {

        public enum StateKey
        {
            menu,
            runLevel,
            infoPage,
            sandbox,
            level1,
            level2,
            enemyInfo,
            structureInfo
        }

        public StateKey _selectedLevel = StateKey.sandbox;

        public Dictionary<StateKey, BaseState> StateDictionary;

        public BaseStateLibrary()
        {
            
        }

        internal BaseState GetState(StateKey key)
        {
            return StateDictionary[key];
        }
    }
}
