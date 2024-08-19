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
using Microsoft.Xna.Framework.Media;
using TowerDefenceGame.Managers;

namespace TowerDefenceGame.StateMachines.LevelState.Sandbox
{
    internal class SandboxState : BaseState
    {

        internal LevelStateMachine _levelStateMachine; //I am not sure if i'm doing this correctly here, but the LevelStateMachine is refered as both "_stateMachine" from the inherited BaseState for the purpose of updating what state is active
                                                       //as well a "_levelStateMachine" for the purpose of adding to and updating the lists of entities in it which aren't present in the BaseStateMachine class and therefore can't be updated using "_stateMachine".


        List<SpawnStructureState> _spawnStates1 = new List<SpawnStructureState>();
        List<SpawnStructureState> _spawnStates2 = new List<SpawnStructureState>();
        List<SpawnStructureState> _spawnStates3 = new List<SpawnStructureState>();
        List<SpawnStructureState> _spawnStates4 = new List<SpawnStructureState>();
        List<SpawnStructureState> _spawnStates5 = new List<SpawnStructureState>();
        CityStructure _city;

        public SandboxState(LevelStateMachine machine, LevelLibrary library) : base (machine, library)
        {
            _levelStateMachine = machine;
            _spawnStates1.Add(new SpawnStructureState(machine, 800, 0, 80, 1, false));
            _spawnStates1.Add(new SpawnStructureState(machine, 500, 0, 80, 1, false));
            

            _spawnStates2.Add(new SpawnStructureState(machine, 1000, 0, 50, 2, false));
            _spawnStates2.Add(new SpawnStructureState(machine, 700, 0, 50, 2, false));
            

            _spawnStates3.Add(new SpawnStructureState(machine, 800, 0, 80, 3, false));
            _spawnStates3.Add(new SpawnStructureState(machine, 500, 0, 80, 3, false));
            

            _spawnStates4.Add(new SpawnStructureState(machine, 1300, 0, 25, 4, false));
            _spawnStates4.Add(new SpawnStructureState(machine, 1000, 0, 25, 4, false));

            _spawnStates5.Add(new SpawnStructureState(machine, 3000, 0, 10, 5, false));
            _spawnStates5.Add(new SpawnStructureState(machine, 1500, 0, 10, 5, false));

            _city = new CityStructure(new Vector2(1000, 960), machine, 9999999);
        }


        public override void EnterState()
        {
            MediaPlayer.Play(Assets.luftrauser);
            MediaPlayer.IsRepeating = true;
            MediaPlayer.Volume = .1f;

            _levelStateMachine.enemyStructures.Add(new EnemySpawnStructure(new Vector2(20, 100), _levelStateMachine, _spawnStates1));
            _levelStateMachine.enemyStructures.Add(new EnemySpawnStructure(new Vector2(100, 20), _levelStateMachine, _spawnStates2));
            _levelStateMachine.enemyStructures.Add(new EnemySpawnStructure(new Vector2(180, 100), _levelStateMachine, _spawnStates3));
            _levelStateMachine.enemyStructures.Add(new EnemySpawnStructure(new Vector2(260, 20), _levelStateMachine, _spawnStates4));
            _levelStateMachine.enemyStructures.Add(new EnemySpawnStructure(new Vector2(340, 100), _levelStateMachine, _spawnStates5));
            _city.ResetCity();
            _levelStateMachine.playerStructures.Add(_city);
            _levelStateMachine._city = _city;
            _levelStateMachine._scrap = 9999999;
            _levelStateMachine._alienScrap = 9999999;
        }

        public override void ExitState()
        {
            _city.RemoveFootprint();
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
