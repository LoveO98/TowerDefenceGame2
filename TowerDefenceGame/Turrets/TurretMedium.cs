using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using TowerDefenceGame.Enemies;
using TowerDefenceGame.HelpfulMethods;
using TowerDefenceGame.Managers;
using TowerDefenceGame.StateMachines.LevelState;
using WinFormForTD;

namespace TowerDefenceGame.Turrets
{
    internal class TurretMedium : TurretBase
    {

        private static int _buyCost = 180;
        private static int _upgradeScrap = 275;
        private static int _aUpgradeScrap = 250;
        private static int _aUpgradeAlien = 250;

        public static int BuyCost { get { return _buyCost; } }
        public static int UpgradeScrap { get { return _upgradeScrap; } }
        public static int AUpgradeScrap { get { return _aUpgradeScrap; } }
        public static int AUpgradeAlien { get { return _aUpgradeAlien; } }

        public TurretMedium(Vector2 pos, LevelStateMachine levelContext) : base(Assets.turretMedium, pos, 90, 45, 300, 1800, false, "Medium Range Level 1", levelContext)
        {
            targetMode = TargetMode.mostHealth;
            _turretTopTex = Assets.turretBrightTop;
            _turretGunTex = Assets.turretCannon;
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
                    _levelContext.disjointedAttacks.Add(new TarArea(_target.Centre, 50, 3000, 0.6f, this, _levelContext));
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
                if (Vector2.Distance(_levelContext.enemies[i].Centre, _target.Centre) < 60)
                {
                    bool kill = false;
                    float damage;
                    (damage, kill) = _levelContext.enemies[i].TakeDamage(_damage, _piercing);
                    _damageDealt += damage;
                    if (kill) _kills++;
                }
            }
        }

        public void OnUpgrade(int upgrade)
        {
            switch (upgrade)
            {
                case 1:
                    if (_levelContext._scrap < _upgradeScrap) return;
                    TurretBase upgradedTurret1 = new TurretMedium2(_pos, _levelContext);
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
                    TurretBase upgradedTurret2 = new TurretZap(_pos, _levelContext);
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
