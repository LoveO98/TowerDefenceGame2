using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using TowerDefenceGame.Managers;
using TowerDefenceGame.StateMachines.LevelState;
using WinFormForTD;

namespace TowerDefenceGame.Turrets
{
    internal class TurretShort : TurretBase
    {

        internal Texture2D _turretCogTex;
        internal float _cogRot;

        
        private static int _buyCost = 150;
        private static int _upgradeScrap = 300;
        private static int _aUpgradeScrap = 250;
        private static int _aUpgradeAlien = 180;

        public static int BuyCost { get { return _buyCost; } }
        public static int UpgradeScrap { get { return _upgradeScrap; } }
        public static int AUpgradeScrap { get { return _aUpgradeScrap; } }
        public static int AUpgradeAlien { get { return _aUpgradeAlien; } }

        public TurretShort(Vector2 pos, LevelStateMachine levelContext) : base(Assets.turretShort, pos, 50, 25, 200, 320, false, "Short Range Level 1", levelContext)
        {
            _turretCogTex = Assets.cogIn50;
            _turretTopTex = Assets.turretBrightTop;
            _turretGunTex = Assets.turretRedPipe;

            _turretInfoForm.UpgradeTurret += OnUpgrade;

            

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
            ParticleManager.CreateStatParticleTopDown(Assets.sparkTex, _structCentre + (_targetDir * 30), 55, 0, 1.1f, 1.3f, 0, _gunRot, 0, Color.Yellow, new Color(Color.Orange, 20));
            ParticleManager.CreateStatParticleTopDown(Assets.sparkCircleTex, _target.Centre, 175, 0, 0.7f, 1.2f, 0, 0, 0, Color.Orange, new Color(Color.Orange, 20));
        }

        public override void Update(GameTime gameTime)
        {
            if (_target != null)
            {
                TargetCheck();
                _cogRot += 0.08f;
            }
            else
            {
                GetTarget();
                _cogRot += 0.01f;
            }

            if (_target != null) Attack(gameTime);
        }


        public override void Draw(SpriteBatch sb)
        {
            sb.Draw(_turretBaseTex, _pos, null, _color, 0, Vector2.Zero, 1f, SpriteEffects.None, 0.31f);
            sb.Draw(_turretCogTex, _pos + new Vector2(25, 25), null, _color, _cogRot, new Vector2(25, 25), 1f, SpriteEffects.None, 0.32f);
            sb.Draw(_turretTopTex, _pos, null, _color, 0, Vector2.Zero, 1f, SpriteEffects.None, 0.33f);
            sb.Draw(_turretGunTex, _pos + new Vector2(25, 25), null, _color, _gunRot, new Vector2(25, 25), 1f, SpriteEffects.None, 0.34f);
        }
        

        public void OnUpgrade(int upgrade)
        {
            switch (upgrade)
            {
                case 1:
                    if (_levelContext._scrap < _upgradeScrap) return;
                    _levelContext._scrap -= _upgradeScrap;
                    TurretBase upgradedTurret1 = new TurretShort2(_pos, _levelContext);
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
                    _levelContext._scrap -= _aUpgradeScrap;
                    _levelContext._alienScrap -= _aUpgradeAlien;
                    TurretBase upgradedTurret2 = new TurretFire(_pos, _levelContext);
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
