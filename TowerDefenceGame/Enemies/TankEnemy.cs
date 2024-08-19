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
    internal class TankEnemy : EnemyBase
    {

        public TankEnemy(Vector2 pos, LevelStateMachine levelContext) : base(pos, Assets.tankEnemy, levelContext)
        {
            _speed = 25;
            _health = 300;
            _maxHealth = _health;
            _armour = 400;
            _scrapValue = 50;
            _alienScrapValue = 30;
            _detectRange = 700;
            _attackRange = 100;
            _attackDamage = 30;
            _attackCD = 2000;
        }


        internal override void AttackParticles()
        {
            ParticleManager.CreateParticleTopDown(Assets.sparkCircleTex, _centre + new Vector2(20, -10), new Vector2(1, 0), 0, 0, 0, 0, 200, 150, 50, 0.8f, 1.2f, 1.3f, 0, 0, Color.Yellow, Color.Orange, new Color(Color.Black, 20));
            for (int i = 0; i < 7; i++)
            {
                ParticleManager.CreateParticleBottomUp(Assets.debreeTex, _target.StructCentre, new Vector2(0, 1), 15, 1, 0.2f, 1.5f, 800, 600, 200, 0.5f, 1f, 0.7f, 12345, 3, Color.Orange * 0.5f, Color.Gray * 0.4f, Color.Black * 0.2f);
            }
        }

        

        public override void LostArmour()
        {
            _speed = 8;
            ParticleManager.CreateParticleBottomUp(Assets.sparkCircleTex, _centre, new Vector2(0, 1), 0, 0, 0, 0, 600, 400, 200, 0.1f, 0.5f, 0.6f, 0, 0, Color.Orange, Color.Gray, new Color(Color.Black, 70));
            for (int i = 0; i < 6; i++)
            {
                ParticleManager.CreateParticleBottomUp(Assets.debreeTex, _centre, new Vector2(0, -1), 4, 1, 2, 3, 600, 400, 200, 0.1f, 0.5f, 0.2f, 12345, 3, Color.Orange, Color.Gray, new Color(Color.Black, 70));
            }

            for (int i = 0; i < 10; i++)
            {
                ParticleManager.CreateParticleBottomUp(Assets.gasBallTex, _centre, new Vector2(0, -1), 1, 1, 0.5f, 2, 1500, 1200, 300, 0.4f, 1.3f, 0.8f, 12345, 3, Color.LightGray * 0.4f, Color.DarkGray * 0.7f, Color.Black * 0.3f);
            }

            _color = Color.Lerp(Color.White, Color.Red, 1 - (_health / _maxHealth));
        }

    }
}
