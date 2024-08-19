using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TowerDefenceGame.HelpfulMethods;
using TowerDefenceGame.Managers;
using TowerDefenceGame.StateMachines.LevelState;
using WinFormForTD;

namespace TowerDefenceGame.Turrets
{
    internal class TurretMedium2 : TurretBase
    {
        public TurretMedium2(Vector2 pos, LevelStateMachine levelContext) : base(Assets.turretMedium, pos, 90, 65, 350, 2000, false, "Medium Range Level 2", levelContext)
        {
            targetMode = TargetMode.mostHealth;
            _turretTopTex = Assets.turretBrightTopMedium2;
            _turretGunTex = Assets.turretCannon2;
            _lockOnTarget = true;
        }

        public override void AttackParticles()
        {
            for (int i = 0; i < 7; i++)
            {
                ParticleManager.CreateParticleTopDown(Assets.gasBallTex, _structCentre, Vector2.Normalize(_target.Centre - _structCentre), 10, 1, 0.2f, 1.5f, 500, 300, 200, 1, 1.8f, 1, 0, 1, Color.Gray, new Color(Color.Gray, 20), new Color(Color.Black, 20));
                ParticleManager.CreateParticleTopDown(Assets.gasBallTex, _target.Centre, new Vector2(1, 0), 10, 2, 0.5f, 2, 500, 150, 350, 0.8f, 1.2f, 1.3f, 0, 1, Color.Red, new Color(Color.Red, 20), new Color(Color.Black, 20));
            }
        }

        public override void Attack(GameTime gameTime)
        {
            if (_target != null)
            {
                SetDirection();
                if (!_isAttacking)
                {
                    _currentCD = _attackCD;
                    AttackParticles();
                    _isAttacking = true;
                    _levelContext.disjointedAttacks.Add(new TarArea(_target.Centre, 70, 7000, 0.4f, this, _levelContext));
                    AOECheck();
                }
            }
            _currentCD -= gameTime.ElapsedGameTime.Milliseconds;
            if (_currentCD <= 0)
            {
                _isAttacking = false;
            }
        }

        private void AOECheck()
        {
            for (int i = 0; _levelContext.enemies.Count > i; i++)
            {
                if (Vector2.Distance(_levelContext.enemies[i].Centre, _target.Centre) < 70)
                {
                    bool kill = false;
                    float damage;
                    (damage, kill) = _levelContext.enemies[i].TakeDamage(_damage, _piercing);
                    _damageDealt += damage;
                    if (kill) _kills++;
                }
            }
        }

    }
}
