using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TowerDefenceGame.Managers;
using TowerDefenceGame.StateMachines.LevelState;
using TowerDefenceGame.Structures;
using Microsoft.Xna.Framework; 
using WinFormForTD;
using TowerDefenceGame.HelpfulMethods;

namespace TowerDefenceGame.Turrets
{
    internal class TurretZap : TurretBase
    {
        int _bounces;
        public TurretZap(Vector2 pos, LevelStateMachine levelContext) : base(Assets.turretZap, pos, 120, 65, 280, 600, false, "Zapper", levelContext)
        {
            targetMode = TargetMode.mostHealth;
            _turretTopTex = Assets.turretBrightTopZap;
            _turretGunTex = Assets.turretGoldAntenna;
            _turretInfoForm.gbTurretHideUpg.Visible = true;
            _bounces = 4;
        }

        public override void PlacedOnStructure(StructureBase structure)
        {
            _placedOnStructure = structure;
            _range *= 1.2f;
            _damage = 85;
            _bounces += 2;
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
                    _levelContext.disjointedAttacks.Add(new ZapAttack(_structCentre, _target, _bounces, _damage, 130, this, _levelContext));
                }
            }
            _currentCD -= gameTime.ElapsedGameTime.Milliseconds;
            if (_currentCD <= 0)
            {
                _isAttacking = false;
            }
        }

        public override void AttackParticles()
        {
            for (int i = 0; i < 6; i++)
            {
                ParticleManager.CreateParticleTopDown(Assets.sparkTex, _structCentre, new Vector2(1, 0), 5, 2, 0.5f, 0.5f, 50, 40, 10, 1, 1.2f, 1, 12345, 0, Color.Teal, new Color(Color.Teal, 50), new Color(Color.Blue, 20));
            }
            ParticleManager.CreateParticleTopDown(Assets.sparkCircleTex, _structCentre, new Vector2(1, 0), 5, 2, 0.5f, 0.5f, 50, 40, 10, 1, 1.2f, 1, 12345, 0, Color.Teal, new Color(Color.Teal, 50), new Color(Color.Blue, 20));
        }
    }
}
