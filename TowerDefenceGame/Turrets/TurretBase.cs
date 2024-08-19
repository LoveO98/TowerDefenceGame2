using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using TowerDefenceGame.Enemies;
using TowerDefenceGame.Managers;
using TowerDefenceGame.Structures;
using System.Diagnostics;
using TowerDefenceGame.StateMachines.LevelState;
using WinFormForTD;

namespace TowerDefenceGame.Turrets
{
    internal abstract class TurretBase : StructureBase
    {
        //Textures for building the animated turret sprite
        internal Texture2D _turretBaseTex;
        internal Texture2D _turretTopTex;
        internal Texture2D _turretGunTex;
        internal float _gunRot = 0;
        internal Rectangle _turretBounds;

        public TurretInfoForm _turretInfoForm;

        
        

        
        internal int _damage;

        internal float _range;

        internal float _damageDealt = 0;
        internal int _kills = 0;

        public float DamageDealt { get { return _damageDealt; } }
        public int Kills { get { return _kills; } }

        public enum TargetMode
        {
            closest,
            furthest,
            mostHealth,
            leastHealth,
            mostTotHealth,
            mostValue,
            leastValue
        }

        public TargetMode targetMode = TargetMode.closest;

        public bool _lockOnTarget;
        public bool _globalLock;

        internal EnemyBase _target;
        internal List<EnemyBase> _inRangeTargets = new List<EnemyBase>();

        internal float _attackCD;
        internal float _currentCD;
        protected float _percentCD;
        

        internal bool _piercing;
        internal string _damageType = "Normal";

        internal bool _onStructure;
        internal StructureBase _placedOnStructure;

        internal bool _isAttacking;

        protected Vector2 _targetDir;

        static int _turretID;
        int _myID;


        public int MyID { get { return _myID; } }
        internal TurretBase(Texture2D tex, Vector2 pos, int health, int damage, int range, int attackCD, bool piercing, string name, LevelStateMachine context) : base(pos, tex, Assets.turretDarkCircleBase, health, context)
        {
            _myID = _turretID;
            _turretID ++;

            _damage = damage;
            _range = range;
            _attackCD = attackCD;
            _currentCD = _attackCD;
            _piercing = piercing;
            _name = name;

            if (_piercing) _damageType = "Piercing";

            _outlineTex = Assets.turretSelectOutline;
            _layerModif = 0.08f;

            InitializeUI();
            _turretBaseTex = Assets.turretDarkCircleBase;
            _turretInfoForm.DestroyTurret += Die;
            _turretInfoForm.LockOnCheck += OnLockOnTarget;
            _turretInfoForm.TargetModeChange += OnChangeTargetingMode;
            _turretInfoForm.LockTargetChange += OnLockGlobal;
            _turretInfoForm.cbTurretLockOn.Checked = _lockOnTarget;
        }

        public override void PlacedOnStructure(StructureBase structure)
        {
            _placedOnStructure = structure;
            _onStructure = true;
            _range *= 1.2f;
            _turretInfoForm.lblTurretRangeValue.Text = _range.ToString();
        }

        public override (int, int) GetUiInfo()
        {
            return ((int)_damageDealt, _kills);
        }

        public virtual void InitializeUI()
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
        }

        public override void UpdateUI()
        {
            _turretInfoForm.lblTurretDamageDealtValue.Text = ((int)_damageDealt).ToString();
            _turretInfoForm.lblTurretKillsValue.Text = _kills.ToString();
            _turretInfoForm.lblTurretHealthValue.Text = _health.ToString() + "/" + _maxHealth.ToString();
            _turretInfoForm.cbTurretLockOn.Checked = _lockOnTarget;
            _turretInfoForm.Left = 1245 + Game1._windowPosition.X;
            _turretInfoForm.Top = 770 + Game1._windowPosition.Y;
            
            _turretInfoForm.cbTurretIgnoreGlobalTargeting.Checked = _globalLock;
        }

        public void OnChangeTargetingMode()
        {
            targetMode = (TargetMode)_turretInfoForm.cbTurretTargetingModes.SelectedIndex;
        }

        public void ChangeTargetingMode(int index)
        {
            targetMode = (TargetMode)index;
        }

        public void OnLockGlobal()
        {
            _globalLock = _turretInfoForm.cbTurretIgnoreGlobalTargeting.Checked;
        }

        public void OnLockOnTarget()
        {
            _lockOnTarget = _turretInfoForm.cbTurretLockOn.Checked;
        }


        public override void ShowUI()
        {
            _turretInfoForm.Show();
        }

        public override void HideUI()
        {
            _turretInfoForm.Hide();
        }


        public override void AddFootprint()
        {
            _levelContext.structureFootprints.Add(new FootprintObject(_pos, _structFootprint, this));
            _levelContext.turretFootprints.Add(new FootprintObject(_pos, _structFootprint, this));
            _levelContext._game1.DrawOnRenderTarget(_levelContext._game1._structureFootprints, _levelContext.structureFootprints);
            _levelContext._game1.DrawOnRenderTarget(_levelContext._game1._turretFootprints, _levelContext.turretFootprints);
        }

        public override void RemoveFootprint()
        {
            for (int i = 0; i < _levelContext.structureFootprints.Count; i++)
            {
                if (_levelContext.structureFootprints[i].Owner == this)
                    _levelContext.structureFootprints.RemoveAt(i);
            }

            for (int i = 0; i < _levelContext.turretFootprints.Count; i++)
            {
                if (_levelContext.turretFootprints[i].Owner == this)
                {
                    _levelContext.turretFootprints.RemoveAt(i);
                }
            }
            _levelContext._game1.DrawOnRenderTarget(_levelContext._game1._structureFootprints, _levelContext.structureFootprints);
            _levelContext._game1.DrawOnRenderTarget(_levelContext._game1._turretFootprints, _levelContext.turretFootprints);
        }

        public override void Update(GameTime gameTime)
        {
            if (_target != null) TargetCheck();
            else GetTarget();

            Attack(gameTime);
        }

        

        public void TargetCheck()
        {
            //Check that the target is actually still alive
            if (_target.Health <= 0) _target = null;
            //If the target is alive, lock-on mode is on and it's in range we don't have to check for another target and can just return 
            if (_lockOnTarget && _target != null && Vector2.Distance(_target.Centre, _structCentre) <= _range) return;
            else GetTarget();
        }

        public void GetTarget()
        {
            
            foreach (EnemyBase enemy in _levelContext.enemies)
            {
                if (Vector2.Distance(enemy.Centre, _structCentre) <= _range) _inRangeTargets.Add(enemy);
            }
            //return out of the method as early as possible if there's no enemies in range to avoid spending unnecessary time trying to pick a target
            if (!_inRangeTargets.Any()) return;

            
            float tempRange = Vector2.Distance(_inRangeTargets[0].Centre, _structCentre);
            float tempValue = _inRangeTargets[0].ScrapValue + _inRangeTargets[0].AlienScrapvalue;
            float tempHealth = _inRangeTargets[0].Health + _inRangeTargets[0].Armour;
            _target = _inRangeTargets[0];
            Debug.WriteLine("Target mode: " + targetMode);
            foreach (EnemyBase enemy in _inRangeTargets)
            {
                float tempDistance = Vector2.Distance(enemy.Centre, _structCentre);
                if (tempDistance <= _range)
                {
                    switch (targetMode)
                    {
                        case TargetMode.closest:

                            if (tempDistance <= tempRange)
                            {
                                tempRange = tempDistance;
                                _target = enemy;
                            }

                            break;

                        case TargetMode.furthest:

                            if (tempDistance >= tempRange)
                            {
                                tempRange = tempDistance;
                                _target = enemy;
                            }

                            break;

                        case TargetMode.mostHealth:

                            if ((enemy.Health + enemy.Armour) > tempHealth)
                            {
                                tempHealth = enemy.Health + enemy.Armour;
                                _target = enemy;
                                tempRange = tempDistance;
                            }
                            else if((enemy.Health + enemy.Armour) == tempHealth)
                            {
                                if(tempRange > tempDistance)
                                {
                                    _target = enemy;
                                    tempRange = tempDistance;
                                }
                            }

                            break;

                        case TargetMode.leastHealth:

                            if ((enemy.Health + enemy.Armour) < tempHealth)
                            {
                                tempHealth = enemy.Health + enemy.Armour;
                                _target = enemy;
                            }
                            else if ((enemy.Health + enemy.Armour) == tempHealth)
                            {
                                if (tempRange > tempDistance)
                                {
                                    _target = enemy;
                                    tempRange = tempDistance;
                                }
                            }

                            break;

                        case TargetMode.mostTotHealth:

                            if (enemy.MaxTotalHA > tempHealth)
                            {
                                tempHealth = enemy.MaxTotalHA;
                                tempRange = tempDistance;
                                _target = enemy;
                            }
                            else if (enemy.MaxTotalHA == tempHealth)
                            {
                                if (tempRange > tempDistance)
                                {
                                    tempRange = tempDistance;
                                    _target = enemy;
                                }
                            }

                            break;

                        case TargetMode.mostValue:

                            if (enemy.ScrapValue + enemy.AlienScrapvalue > tempValue)
                            {
                                tempValue = enemy.ScrapValue + enemy.AlienScrapvalue;
                                _target = enemy;
                            }
                            else if (enemy.ScrapValue + enemy.AlienScrapvalue == tempValue)
                            {
                                if (tempRange > tempDistance)
                                {
                                    tempRange = tempDistance;
                                    _target = enemy;
                                }
                            }

                            break;

                        case TargetMode.leastValue:

                            if (enemy.ScrapValue + enemy.AlienScrapvalue < tempValue)
                            {
                                tempValue = enemy.ScrapValue + enemy.AlienScrapvalue;
                                _target = enemy;
                            }
                            else if (enemy.ScrapValue + enemy.AlienScrapvalue == tempValue)
                            {
                                if (tempRange > tempDistance)
                                {
                                    tempRange = tempDistance;
                                    _target = enemy;
                                }
                            }

                            break;

                        default:

                            if (tempDistance <= tempRange)
                            {
                                tempRange = tempDistance;
                                _target = enemy;
                            }

                            break;
                    }
                }
            }
            //Clear the list of potential targets to avoid the list getting filled with dead or repeated enemies
            //This should also avoid the garbage collector not deleting dead enemies from memory
            _inRangeTargets.Clear();
            
        }


        public virtual void Attack(GameTime gameTime)
        {
            if(_target != null)
            {
                SetDirection();
                if (!_isAttacking)
                {
                    _currentCD = _attackCD;
                    AttackParticles();
                    _isAttacking = true;
                    bool kill = false;
                    float damage;
                    (damage, kill) = _target.TakeDamage(_damage, _piercing);
                    _damageDealt += damage;
                    if (kill)
                    {
                        _kills++;
                        _target = null;
                    }
                }
            }
            _currentCD -= gameTime.ElapsedGameTime.Milliseconds;
            if (_currentCD <= 0)
            {
                _isAttacking = false;
            }
        }

        public override void Die()
        {
            DeathParticles();
            RemoveFootprint();
            _levelContext.turrets.Remove(this);
            _health = 0;
            _turretInfoForm.DestroyTurret -= Die;
            _turretInfoForm.LockOnCheck -= OnLockOnTarget;
            _turretInfoForm.TargetModeChange -= OnChangeTargetingMode;
            _turretInfoForm.LockTargetChange -= OnLockGlobal;
        }

        public abstract void AttackParticles();

        public override void DeathParticles()
        {
            for (int i = 0; i < 10; i++)
            {
                ParticleManager.CreateParticleBottomUp(Assets.sparkTex, _structCentre, new Vector2(0, 1), 10, 5, 1, 0.5f, 500, 400, 100, 0.2f, 3, 1, 12345, 0, Color.Yellow, Color.Orange, new Color(Color.Black, 20));
            }
            for (int i = 0; i < 15; i++)
            {
                ParticleManager.CreateParticleBottomUp(Assets.gasBallTex, _structCentre, new Vector2(0, 1), 10, 4, 1, 2, 500, 400, 100, 0.2f, 1.5f, 0.5f, 12345, 0, new Color(Color.Black, 20), new Color(Color.Black, 170), new Color(Color.Black, 20));
                ParticleManager.CreateParticleBottomUp(Assets.debreeTex, _structCentre, new Vector2(0, 1), 10, 4, 1, 2, 500, 400, 100, 0.2f, 1, 0.5f, 12345, 1, Color.SandyBrown, Color.Brown, new Color(Color.Black, 20));
            }
        }

        protected void SetDirection()
        {
            _targetDir = _target.Centre - _structCentre;
            _targetDir.Normalize();
            _gunRot = (float)Math.Atan2(_targetDir.Y, _targetDir.X);
        }

        //public override void Draw(SpriteBatch sb)
        //{
        //    sb.Draw(_tex, _pos, Color.White);
        //}



        public override void Draw(SpriteBatch sb)
        {
            sb.Draw(_turretBaseTex, _pos, null, _color, 0, Vector2.Zero, 1f, SpriteEffects.None, 0.31f);
            sb.Draw(_turretTopTex, _pos, null, _color, 0, Vector2.Zero, 1f, SpriteEffects.None, 0.32f);
            sb.Draw(_turretGunTex, _pos + new Vector2(25,25), null , _color, _gunRot, new Vector2(25,25), 1f, SpriteEffects.None, 0.33f);
        }

        public virtual void DrawTarget(SpriteBatch sb)
        {
            sb.Draw(Assets.pixelCircle, _target.Centre - new Vector2(Assets.pixelCircle.Width / 2, Assets.pixelCircle.Height / 2), null, Color.Magenta, 0, Vector2.Zero, 1f, SpriteEffects.None, 0.7f);
        }

        

    }
}
