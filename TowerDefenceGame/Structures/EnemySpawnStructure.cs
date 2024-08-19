using System;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TowerDefenceGame.Managers;
using TowerDefenceGame.Enemies;
using TowerDefenceGame.StateMachines.LevelState;

namespace TowerDefenceGame.Structures
{
    internal class EnemySpawnStructure : StructureBase
    {
        public bool _inactive;

        List<SpawnStructureState> _spawnStates;
        SpawnStructureState _activeState;
        
        public EnemySpawnStructure(Vector2 pos, LevelStateMachine context, List<SpawnStructureState> spawnStates) : base(pos, Assets.enemySpawn, Assets.square100x100, 9000, context)
        {
            _name = "Enemy Spawner";
            _outlineTex = Assets.spawnerSelectOutline;
            _spawnStates = spawnStates;
            foreach(SpawnStructureState spawnState in _spawnStates)
            {
                spawnState.AssignSpawner(this);
            }
            _activeState = _spawnStates[0];
            _activeState.EnterState();
        }

        public override void Update(GameTime gameTime)
        {
            if (_inactive) return;
            _activeState.UpdateState(gameTime);
        }

        public void SwitchState()
        {
            if (_activeState._stop)
            {
                Inactivate();
                return;
            }
            _activeState = _spawnStates.ElementAtOrDefault(_spawnStates.IndexOf(_activeState) + 1) ?? _spawnStates[0];
            _activeState.EnterState();
        }

        public void Inactivate()
        {
            _color = Color.Gray;
            _inactive = true;
        }

    }
}
