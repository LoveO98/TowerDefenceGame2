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
    internal class WalkingFortressEnemy : EnemyBase
    {

        public WalkingFortressEnemy(Vector2 pos, LevelStateMachine levelContext) : base(pos, Assets.walkingFortressEnemy, levelContext)
        {
            _speed = 10;
            _health = 800;
            _maxHealth = _health;
            _armour = 1500;
            _scrapValue = 150;
            _alienScrapValue = 300;
            _detectRange = 500;
            _attackRange = 120;
            _attackDamage = 75;
            _attackCD = 2500;
        }


        internal override void AttackParticles()
        {
            ParticleManager.CreateParticleTopDown(Assets.sparkCircleTex, _centre, new Vector2(1, 0), 0, 0, 0, 0, 200, 150, 50, 1, 1.8f, 1.9f, 0, 0, Color.Yellow, Color.Orange, new Color(Color.Black, 20));
            for (int i = 0; i < 10; i++)
            {
                ParticleManager.CreateParticleBottomUp(Assets.debreeTex, _target.StructCentre, new Vector2(0, 1), 15, 1, 0.2f, 1.5f, 800, 600, 200, 0.5f, 1f, 0.7f, 12345, 3, Color.Orange * 0.5f, Color.Gray * 0.4f, Color.Black * 0.2f);
            }
        }

    }
}
