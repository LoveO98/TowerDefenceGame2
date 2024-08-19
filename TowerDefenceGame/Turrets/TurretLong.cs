using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TowerDefenceGame.Managers;
using TowerDefenceGame.StateMachines.LevelState;
using WinFormForTD;

namespace TowerDefenceGame.Turrets
{
    internal class TurretLong : TurretBase
    {

        private static int _buyCost = 200;
        private static int _upgradeScrap = 350;
        private static int _aUpgradeScrap = 300;
        private static int _aUpgradeAlien = 150;

        public static int BuyCost { get { return _buyCost; } }
        public static int UpgradeScrap { get { return _upgradeScrap; } }
        public static int AUpgradeScrap { get { return _aUpgradeScrap; } }
        public static int AUpgradeAlien { get { return _aUpgradeAlien; } }

        public TurretLong(Vector2 pos, LevelStateMachine levelContext) : base(Assets.turretLong, pos, 40, 70, 550, 1100, false, "Long Range Level 1", levelContext)
        {
            targetMode = TargetMode.mostHealth;
            _turretTopTex = Assets.turretBrightTop;
            _turretGunTex = Assets.turretPointer;
            _turretInfoForm.UpgradeTurret += OnUpgrade;
            _lockOnTarget = true;
        }

        public override void InitializeUI()
        {
            _turretInfoForm = new TurretInfoForm();
            _turretInfoForm.Left = 1245 + Game1._windowPosition.X;
            _turretInfoForm.Top = 770 + Game1._windowPosition.Y;
            _turretInfoForm.lblTurretName.Text = _name;
            _turretInfoForm.lblTurretDamageTypeValue.Text = _damageType;
            _turretInfoForm.lblTurretAttackSpeedValue.Text = (1000 / _attackCD).ToString(".##") + " attacks/s";
            _turretInfoForm.lblTurretDamageValue.Text = _damage.ToString();
            _turretInfoForm.lblTurretRangeValue.Text = _range.ToString();
            _turretInfoForm.lblTurretHealthValue.Text = _health.ToString() + "/" + _health.ToString();
            _turretInfoForm.cbTurretTargetingModes.SelectedIndex = (int)targetMode;
            _turretInfoForm.lblTurretUpgradeScrapValue1.Text = UpgradeScrap.ToString();
            _turretInfoForm.lblTurretUpgradeScrapValue2.Text = AUpgradeScrap.ToString();
            _turretInfoForm.lblTurretUpgradeAlienScrapValue.Text = AUpgradeAlien.ToString();
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
                    if (_levelContext._scrap < _upgradeScrap) return;
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
                    if (_levelContext._scrap < _aUpgradeScrap || _levelContext._alienScrap < _aUpgradeAlien) return;
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
