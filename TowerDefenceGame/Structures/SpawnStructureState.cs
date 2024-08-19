using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TowerDefenceGame.Enemies;
using TowerDefenceGame.StateMachines.LevelState;

namespace TowerDefenceGame.Structures
{
    internal class SpawnStructureState
    {
        public bool _stop = false;
        public float _spawnDelay;
        public float _countDown;
        public float _initialDelay;
        public float _initialDelayCD;

        public int _spawnAmount;
        public int _remainingSpawn;

        public int _spawnType;

        public LevelStateMachine _levelContext;
        public EnemySpawnStructure _spawner;

        public SpawnStructureState(LevelStateMachine levelContext, float spawnDelay, float initalDelay, int spawnAmount, int spawnType, bool stop)
        {
            _levelContext = levelContext;
            _stop = stop;
            _spawnDelay = spawnDelay;
            _initialDelay = initalDelay;
            _spawnAmount = spawnAmount;
            _spawnType = spawnType;
        }

        public void AssignSpawner(EnemySpawnStructure spawner)
        {
            _spawner = spawner;
        }

        public void EnterState()
        {
            _remainingSpawn = _spawnAmount;
            _initialDelayCD = _initialDelay;
            _countDown = _spawnDelay;
        }

        public void UpdateState(GameTime gameTime)
        {
            if(_initialDelayCD > 0)
            {
                _initialDelayCD -= gameTime.ElapsedGameTime.Milliseconds;
                return;
            }

            if(_countDown > 0)
            {
                _countDown -= gameTime.ElapsedGameTime.Milliseconds;
                return;
            }
            _countDown = _spawnDelay;
            Spawn();
        }
        public void Spawn()
        {

            switch (_spawnType)
            {
                case 1:

                    _levelContext.enemies.Add(new BasicEnemy(_spawner._structCentre, _levelContext));

                    break;

                case 2:

                    _levelContext.enemies.Add(new HeavyEnemy(_spawner._structCentre, _levelContext));

                    break;

                case 3:

                    _levelContext.enemies.Add(new RedRocketEnemy(_spawner._structCentre, _levelContext));

                    break;

                case 4:

                    _levelContext.enemies.Add(new TankEnemy(_spawner._structCentre, _levelContext));

                    break;

                case 5:

                    _levelContext.enemies.Add(new WalkingFortressEnemy(_spawner._structCentre, _levelContext));

                    break;
            }

            _remainingSpawn--;
            if (_remainingSpawn <= 0) _spawner.SwitchState();
        }

    }
}
