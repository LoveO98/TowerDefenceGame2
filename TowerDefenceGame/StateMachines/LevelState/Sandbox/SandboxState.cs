using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TowerDefenceGame.Structures;
using TowerDefenceGame.Turrets;
using TowerDefenceGame.HelpfulMethods;
using Microsoft.Xna.Framework.Input;

namespace TowerDefenceGame.StateMachines.LevelState.Sandbox
{
    internal class SandboxState : BaseState
    {

        internal LevelStateMachine _levelStateMachine; //I am not sure if i'm doing this correctly here, but the LevelStateMachine is refered as both "_stateMachine" from the inherited BaseState for the purpose of updating what state is active
        //as well a "_levelStateMachine" for the purpose of adding to and updating the lists of entities in it which aren't present in the BaseStateMachine class and therefore can't be updated using "_stateMachine".

        

        public SandboxState(LevelStateMachine machine, LevelLibrary library) : base (machine, library)
        {
            _levelStateMachine = machine;
        }


        public override void EnterState()
        {
            
        }

        public override void ExitState()
        {

        }

        public override void UpdateState(GameTime gameTime)
        {
            _levelStateMachine.UpdateEnemies(gameTime);
            _levelStateMachine.UpdateTurrets(gameTime);
            _levelStateMachine.UpdateEnemyStructs(gameTime);
            _levelStateMachine.UpdateAttacks(gameTime);
        }

        public override void DrawState(SpriteBatch sb)
        {
            
        }

    }
}
