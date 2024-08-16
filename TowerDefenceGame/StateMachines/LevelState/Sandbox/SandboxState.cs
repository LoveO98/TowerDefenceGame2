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
            _levelStateMachine.SetCityLocation(new Vector2(900, 700));

            _levelStateMachine.enemyStructures.Add(new EnemySpawnStructure(new Vector2(50, 100), _levelStateMachine, 1, 400, 1000));
            _levelStateMachine.enemyStructures.Add(new EnemySpawnStructure(new Vector2(160, 100), _levelStateMachine, 1, 400, 1000));
            //_levelStateMachine.enemyStructures.Add(new EnemySpawnStructure(new Vector2(270, 100), _levelStateMachine, 1, 400, 1000));
            //_levelStateMachine.enemyStructures.Add(new EnemySpawnStructure(new Vector2(380, 100), _levelStateMachine, 1, 400, 1000));
            //_levelStateMachine.enemyStructures.Add(new EnemySpawnStructure(new Vector2(490, 100), _levelStateMachine, 1, 400, 1000));

            //_levelStateMachine.turrets.Add(new TurretShort(new Vector2(50, 400), _levelStateMachine));
            //_levelStateMachine.turrets.Add(new TurretFire(new Vector2(100, 400), _levelStateMachine));
            //_levelStateMachine.turrets.Add(new TurretFire(new Vector2(150, 400), _levelStateMachine));
            //_levelStateMachine.turrets.Add(new TurretFire(new Vector2(200, 400), _levelStateMachine));
            //_levelStateMachine.turrets.Add(new TurretFire(new Vector2(250, 400), _levelStateMachine));
            //_levelStateMachine.turrets.Add(new TurretFire(new Vector2(300, 400), _levelStateMachine));
            //_levelStateMachine.turrets.Add(new TurretFire(new Vector2(350, 400), _levelStateMachine));
            //_levelStateMachine.turrets.Add(new TurretFire(new Vector2(400, 400), _levelStateMachine));
            //_levelStateMachine.turrets.Add(new TurretFire(new Vector2(450, 400), _levelStateMachine));

        }

        public override void ExitState()
        {

        }

        public override void UpdateState(GameTime gameTime)
        {
            _levelStateMachine.UpdateEnemies(gameTime);
            _levelStateMachine.UpdateTurrets(gameTime);
            _levelStateMachine.UpdateEnemyStructs(gameTime);
        }


        public override void CheckSwitchState()
        {
            throw new NotImplementedException();
        }

    }
}
