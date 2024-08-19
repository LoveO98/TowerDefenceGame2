using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TowerDefenceGame.Managers;
using TowerDefenceGame.StateMachines.LevelState;

namespace TowerDefenceGame.Enemies
{
    internal class HeavyEnemy : EnemyBase
    {

        public HeavyEnemy(Vector2 pos, LevelStateMachine levelContext) : base(pos, Assets.heavyEnemy, levelContext)
        {
            
            _speed = 15;
            _health = 80;
            _maxHealth = _health;
            _armour = 100;
            _scrapValue = 20;
            _alienScrapValue = 0;
            _detectRange = 500;
            _attackRange = 50;
            _attackDamage = 20;
            _attackCD = 1500;
        }


    }
}
