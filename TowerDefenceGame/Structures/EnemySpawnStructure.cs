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
        int _spawnType;
        int _spawnAmount;

        int _remainingSpawn;

        int _spawnCD;
        float _currentCD;

        bool _isSpawning;
        bool _inactive;

        public EnemySpawnStructure(Vector2 pos, LevelStateMachine context, int spawnType, int spawnAmount, int spawnCD) : base(pos, Assets.enemySpawn, Assets.square100x100, 9000, context)
        {
            _spawnType = spawnType;
            _spawnAmount = spawnAmount;
            _remainingSpawn = _spawnAmount;
            _spawnCD = spawnCD;
            _currentCD = _spawnCD;
            _name = "Enemy Spawner";
            _outlineTex = Assets.spawnerSelectOutline;
        }


        
        public override void Update(GameTime gameTime)
        {
            if (_inactive) return;
            Spawn(gameTime);
        }

        public void Spawn(GameTime gameTime)
        {

            if (!_isSpawning)
            {
                _isSpawning = true;
                switch (_spawnType)
                {
                    case 1:

                        _levelContext.enemies.Add(new BasicEnemy(_structCentre, _levelContext));

                        break;

                    case 2:

                        _levelContext.enemies.Add(new HeavyEnemy(_structCentre, _levelContext));

                        break;

                    case 3:

                        _levelContext.enemies.Add(new RedRocketEnemy(_structCentre, _levelContext));

                        break;

                    case 4:

                        _levelContext.enemies.Add(new TankEnemy(_structCentre, _levelContext));

                        break;

                    case 5:

                        _levelContext.enemies.Add(new WalkingFortressEnemy(_structCentre, _levelContext));

                        break;
                }

                _remainingSpawn--;
                if (_remainingSpawn <= 0) Inactive();
                return;
            }

            _currentCD -= gameTime.ElapsedGameTime.Milliseconds;
            if (_currentCD <= 0)
            {
                _currentCD = _spawnCD;
                _isSpawning = false;
            }
        }


        public void Inactive()
        {
            _color = Color.Gray;
            _inactive = true;
        }

    }
}
