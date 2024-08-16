using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TowerDefenceGame.Managers;
using TowerDefenceGame.StateMachines.LevelState;

namespace TowerDefenceGame.Turrets
{
    internal class TurretLong : TurretBase
    {
        public TurretLong(Vector2 pos, LevelStateMachine levelContext) : base(Assets.turretLong, pos, 40, 70, 550, 1100, false, "Long Range Level 1", levelContext)
        {
            targetMode = TargetMode.mostHealth;
            _turretTopTex = Assets.turretBrightTop;
            _turretGunTex = Assets.turretPointer;
            _turretInfoForm.UpgradeTurret += OnUpgrade;
            _lockOnTarget = true;
        }

        public override void AttackParticles()
        {
            ParticleManager.CreateParticleTopDown(Assets.sparkTex, _structCentre, _target.Centre - _structCentre, 0, 1, 0, 0.5f, 50, 40, 10, 1, 1.8f, 1, 12345, 0, Color.Teal, new Color(Color.Blue, 20), new Color(Color.Black, 20));
            ParticleManager.CreateParticleTopDown(Assets.sparkCircleTex, _target.Centre, new Vector2(1, 0), 0, 0, 0, 0, 200, 150, 50, 0.8f, 1.2f, 1.3f, 0, 0, Color.Teal, new Color(Color.Yellow, 20), new Color(Color.Black, 20));
        }


        public void OnUpgrade(int upgrade)
        {
            switch (upgrade)
            {
                case 1:
                    TurretBase upgradedTurret1 = new TurretLong2(_pos, _levelContext);
                    _levelContext.turrets.Add(upgradedTurret1);
                    upgradedTurret1.AddFootprint();
                    upgradedTurret1.targetMode = targetMode;
                    upgradedTurret1._lockOnTarget = _lockOnTarget;
                    upgradedTurret1._damageDealt = _damageDealt;
                    upgradedTurret1._kills = _kills;
                    if (_onStructure)
                    {
                        _placedOnStructure.BuildTurretOnTop(upgradedTurret1);
                        upgradedTurret1.PlacedOnStructure(_placedOnStructure);
                    }
                    break;

                case 2:
                    TurretBase upgradedTurret2 = new TurretPierce(_pos, _levelContext);
                    _levelContext.turrets.Add(upgradedTurret2);
                    upgradedTurret2.AddFootprint();
                    upgradedTurret2.targetMode = targetMode;
                    upgradedTurret2._lockOnTarget = _lockOnTarget;
                    upgradedTurret2._damageDealt = _damageDealt;
                    upgradedTurret2._kills = _kills;
                    if (_onStructure)
                    {
                        _placedOnStructure.BuildTurretOnTop(upgradedTurret2);
                        upgradedTurret2.PlacedOnStructure(_placedOnStructure);
                    }
                    break;
            }
            _turretInfoForm.UpgradeTurret -= OnUpgrade;
            Die();
        }

    }
}
