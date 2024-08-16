using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using TowerDefenceGame.Managers;
using TowerDefenceGame.StateMachines.LevelState;
using WinFormForTD;

namespace TowerDefenceGame.Turrets
{
    internal class TurretShort2 : TurretBase
    {
        internal Texture2D _turretCogTex;
        internal float _cogRot;
        internal bool _barrelSwitch;
        public TurretShort2(Vector2 pos, LevelStateMachine levelContext) : base(Assets.turretShort2, pos, 120, 35, 230, 200, false, "Short Range Level 2", levelContext)
        {
            _turretCogTex = Assets.cogIn50;
            _turretTopTex = Assets.turretBrightTopShort2;
            _turretGunTex = Assets.turretRedPipe2;
            //_turretInfoForm.gbTurretHideUpg.Size = new System.Drawing.Size(193, 231);
            _turretInfoForm.gbTurretHideUpg.Visible = true;
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

        public override void Attack(GameTime gameTime)
        {
            SetDirection();
            if (!_isAttacking)
            {
                AttackParticles();
                _barrelSwitch = !_barrelSwitch;
                _isAttacking = true;
                bool kill;
                float damage;
                (damage, kill) = _target.TakeDamage(_damage, _piercing);
                _damageDealt += damage;
                if (kill) _kills++;
            }

            _currentCD -= gameTime.ElapsedGameTime.Milliseconds;
            if (_currentCD <= 0)
            {
                _currentCD = _attackCD;
                _isAttacking = false;
            }
        }

        public override void AttackParticles()
        {
            if(_barrelSwitch)
                ParticleManager.CreateStatParticleTopDown(Assets.sparkTex, _structCentre + (_targetDir * 30) + Vector2.Reflect(_targetDir, new Vector2(1.5f, 1.5f)), 50, 0, 1.1f, 1.5f, 0, _gunRot, 0, Color.Teal, new Color(Color.Blue, 20));
            else
                ParticleManager.CreateStatParticleTopDown(Assets.sparkTex, _structCentre + (_targetDir * 30) - Vector2.Reflect(_targetDir, new Vector2(1.5f, 1.5f)), 50, 0, 1.1f, 1.5f, 0, _gunRot, 0, Color.Teal, new Color(Color.Blue, 20));

            ParticleManager.CreateStatParticleTopDown(Assets.sparkCircleTex, _target.Centre, 200, 0, 1.1f, 2f, 0, 0, 0, Color.Teal, new Color(Color.Blue, 20));
        }

        public override void Draw(SpriteBatch sb)
        {
            sb.Draw(_turretBaseTex, _pos, null, _color, 0, Vector2.Zero, 1f, SpriteEffects.None, 0.31f);
            sb.Draw(_turretCogTex, _pos + new Vector2(25, 25), null, _color, _cogRot, new Vector2(25, 25), 1f, SpriteEffects.None, 0.32f);
            sb.Draw(_turretTopTex, _pos, null, _color, 0, Vector2.Zero, 1f, SpriteEffects.None, 0.33f);
            sb.Draw(_turretGunTex, _pos + new Vector2(25, 25), null, _color, _gunRot, new Vector2(25, 25), 1f, SpriteEffects.None, 0.34f);
        }

    }
}
