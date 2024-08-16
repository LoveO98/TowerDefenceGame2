using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TowerDefenceGame.Managers;
using System.Diagnostics;
using TowerDefenceGame.StateMachines.LevelState;

namespace TowerDefenceGame.Enemies
{
    internal class BasicEnemy : EnemyBase
    {
        
        public BasicEnemy(Vector2 pos, LevelStateMachine levelContext) : base(pos, Assets.basicEnemy, levelContext)
        {
            
            _speed = 20;
            _health = 110;
            _armour = 0;
            _scrapValue = 20;
            _alienScrapValue = 0;
            _detectRange = 500;
            _attackRange = 30;
            _attackDamage = 5;
            _attackCD = 1000;
        }


    }
}
