using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TowerDefenceGame.Structures;

namespace TowerDefenceGame.StateMachines.LevelState
{
    internal class Level2State : BaseState
    {
        //I am not sure if i'm doing this correctly here, but the LevelStateMachine is refered as both "_stateMachine" from the inherited BaseState for the purpose of updating what state is active
        //as well a "_levelStateMachine" for the purpose of adding to and updating the lists of entities in it which aren't present in the BaseStateMachine class and therefore can't be updated using "_stateMachine".
        internal LevelStateMachine _levelStateMachine;

        List<SpawnStructureState> _spawnStates1 = new List<SpawnStructureState>();
        List<SpawnStructureState> _spawnStates2 = new List<SpawnStructureState>();
        List<SpawnStructureState> _spawnStates3 = new List<SpawnStructureState>();
        List<SpawnStructureState> _spawnStates4 = new List<SpawnStructureState>();
        CityStructure _city;

        int _startScrap = 450;
        public Level2State(LevelStateMachine machine, LevelLibrary library) : base(machine, library)
        {
            _levelStateMachine = machine;
            _spawnStates1.Add(new SpawnStructureState(machine, 700, 1000, 50, 1, false));
            _spawnStates1.Add(new SpawnStructureState(machine, 1000, 1000, 30, 2, false));
            _spawnStates1.Add(new SpawnStructureState(machine, 1500, 5000, 10, 4, false));
            _spawnStates1.Add(new SpawnStructureState(machine, 750, 5000, 20, 3, true));

            _spawnStates2.Add(new SpawnStructureState(machine, 500, 10000, 40, 1, false));
            _spawnStates2.Add(new SpawnStructureState(machine, 1200, 2000, 60, 2, false));
            _spawnStates2.Add(new SpawnStructureState(machine, 800, 5000, 50, 3, true));

            _spawnStates3.Add(new SpawnStructureState(machine, 700, 1000, 50, 1, false));
            _spawnStates3.Add(new SpawnStructureState(machine, 1000, 3000, 30, 2, false));
            _spawnStates3.Add(new SpawnStructureState(machine, 1500, 5000, 10, 4, false));
            _spawnStates3.Add(new SpawnStructureState(machine, 750, 5000, 1, 5, true));

            _spawnStates4.Add(new SpawnStructureState(machine, 700, 5000, 50, 1, false));
            _spawnStates4.Add(new SpawnStructureState(machine, 1000, 1000, 30, 2, false));
            _spawnStates4.Add(new SpawnStructureState(machine, 1500, 2000, 10, 4, false));
            _spawnStates4.Add(new SpawnStructureState(machine, 750, 15000, 1, 5, true));

            _city = new CityStructure(new Vector2(1300, 600), machine);
        }


        public override void EnterState()
        {
            _levelStateMachine.enemyStructures.Add(new EnemySpawnStructure(new Vector2(120, 100), _levelStateMachine, _spawnStates1));
            _levelStateMachine.enemyStructures.Add(new EnemySpawnStructure(new Vector2(160, 300), _levelStateMachine, _spawnStates2));
            _levelStateMachine.enemyStructures.Add(new EnemySpawnStructure(new Vector2(300, 100), _levelStateMachine, _spawnStates3));
            _levelStateMachine.enemyStructures.Add(new EnemySpawnStructure(new Vector2(20, 20), _levelStateMachine, _spawnStates4));
            _city.ResetCity();
            _levelStateMachine.playerStructures.Add(_city);
            _levelStateMachine._city = _city;
            _levelStateMachine._scrap = _startScrap;
            _levelStateMachine._alienScrap = 0;
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
