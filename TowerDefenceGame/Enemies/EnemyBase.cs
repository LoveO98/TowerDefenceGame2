using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using System.Text;
using System.Threading.Tasks;
using TowerDefenceGame.Managers;
using TowerDefenceGame.Structures;
using TowerDefenceGame.Turrets;
using System.Collections;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using System.Diagnostics;
using TowerDefenceGame.StateMachines.LevelState;

namespace TowerDefenceGame.Enemies
{
    internal abstract class EnemyBase
    {
        internal Texture2D _tex;
        public Texture2D Texture { get { return _tex; } }

        Rectangle _hitBox;
        public Rectangle HitBox { get { return _hitBox; } }

        internal StructureBase _target;

        //CHANGE TO INT IF NO MATH THAT TURNS THEM INTO FLOAT
        protected float _detectRange;
        protected float _attackRange;
        protected float _attackDamage;

        protected Vector2 _pos;
        public Vector2 Pos { get { return _pos; } }

        protected Vector2 _centre;
        public Vector2 Centre { get {  return _centre; } }

        protected Vector2 _relativeCentre;
        public Vector2 RelativeCentre {  get { return _relativeCentre; } }

        protected Vector2 _direction;

        protected float _speed;
        public float Speed { get { return _speed; } }

        float _speedModifier;
        public float SpeedModifier {  get { return _speedModifier; } set { _speedModifier = value; } }

        protected float _currentSpeed;

        protected float _health;
        public float Health { get { return _health; } }


        protected float _armour;
        public float Armour { get { return _armour; } }

        protected float _maxHealth;
        protected float _maxArmour;

        public float MaxTotalHA {  get { return _maxHealth + _maxArmour; } }

        protected float _spriteBobbing = 0;

        internal int _scrapValue;
        public int ScrapValue { get { return _scrapValue; } }

        internal int _alienScrapValue;
        public int AlienScrapvalue { get { return _alienScrapValue; } }

        protected Color _color = Color.White;

        internal LevelStateMachine _levelContext;

        static int _enemyID;
        public int _myID;

        protected float _attackCD;
        protected float _currentCD;
        protected bool _isAttacking;


        protected EnemyBase(Vector2 pos, Texture2D tex,  LevelStateMachine levelContext)
        {
            _myID = _enemyID;
            _enemyID++;
            _pos = pos;
            _tex = tex;
            _currentSpeed = _speed;
            _maxHealth = _health;
            _maxArmour = _armour;
            _levelContext = levelContext;
            _currentCD = _attackCD;
            _relativeCentre = new Vector2(_tex.Width / 2, _tex.Height / 2);
            _centre = _relativeCentre + _pos;
            _hitBox = new Rectangle((int)_pos.X, (int)_pos.Y, _tex.Width, _tex.Height);
            _target = FindTarget();
        }


        public void Update(GameTime gameTime)
        {
            _centre = _relativeCentre + _pos;
            if (Vector2.Distance(_target.StructCentre, _centre) > _attackRange && !_isAttacking)
            {
                Travel(gameTime);
                _hitBox.X = (int)_pos.X;
                _hitBox.Y = (int)_pos.Y;
                _target = FindTarget(); //Look for targets while travelling;
            }
            else
            {
                Attack(gameTime);
            }
        }


        public void Travel(GameTime gameTime)
        {
            _direction = _target.StructCentre - _pos;
            _direction.Normalize();
            _pos += _direction * _speed * (float)gameTime.ElapsedGameTime.TotalSeconds;
            _spriteBobbing = (float)Math.Sin(_pos.X) * 3;
        }

        public virtual void Attack(GameTime gameTime)
        {
            if (!_isAttacking)
            {
                AttackParticles();
                _isAttacking = true;
                _target.TakeDamage((int)_attackDamage);
                return;
            }
            
            _currentCD -= gameTime.ElapsedGameTime.Milliseconds;
            if(_currentCD <= 0)
            {
                _currentCD = _attackCD;
                _target = FindTarget(); //Start looking for a new target when finished with attack. Will most likely be the same target unless it has been destroyed.
                _isAttacking = false;
            }
        }

        

        public virtual StructureBase FindTarget()
        {
            StructureBase tempTarget = _levelContext.City;
            StructureBase tempTarget2 = tempTarget;
            float tempDistance;
            foreach (StructureBase playerBase in _levelContext.playerStructures)
            {
                tempDistance = Vector2.Distance(playerBase.StructCentre, _centre);
                if (tempDistance <= _detectRange && tempDistance <= Vector2.Distance(tempTarget.StructCentre, _centre))
                {
                    tempTarget = playerBase;
                }
            }

            foreach (TurretBase turret in _levelContext.turrets)
            {
                tempDistance = Vector2.Distance(turret.StructCentre, _centre);
                if (tempDistance <= _detectRange && tempDistance <= Vector2.Distance(tempTarget2.StructCentre, _centre))
                {
                    tempTarget2 = turret;
                }
            }
            //I want enemies to target structures first and since your turret might not be exactly centred on the structure i give you a bit of leeway.
            if (Vector2.Distance(tempTarget.StructCentre, _centre) - Vector2.Distance(tempTarget2.StructCentre, _centre) > 20)
            {
                tempTarget = tempTarget2;
            }

            return tempTarget;
        }

        //This method returns a float of the effective damage dealt. Ex: A turret deals 50 dmg to an enemy with 10 health, that's just 10 effective damage since the rest was wasted
        //This is purely for tracking damage more accurately in the turret statistics.
        public virtual (float, bool) TakeDamage(float damage, bool piercing)
        {
            ParticleManager.CreateStatParticleBottomUp(Assets.pixelCircle, _centre, 20, 0, 0.5f, 0.5f, 0, 0, 0, Color.Magenta, Color.Magenta);
            float remainingDamage = 0;
            float damageDone;
            if (_armour <= 0)
            {
                if (piercing) damage *= 0.75f;
                _health -= damage;
                _color = Color.Lerp(Color.White, Color.Red, 1 - (_health / _maxHealth));
                if (_health <= 0)
                {
                    damageDone = damage + _health;
                    Die();
                    return (damageDone, true);
                }
                return (damage, false);
            }
            else
            {
                if (!piercing) damage *= 0.5f;
                _armour -= damage;
                if (_armour <= 0)
                {
                    LostArmour();
                    damageDone = damage + _armour;
                    if(piercing) remainingDamage = MathF.Abs(_armour) * 0.75f;
                    else remainingDamage = MathF.Abs(_armour) * 2;
                }
                else return (damage, false);
            }
            _health -= remainingDamage;
            if (_health <= 0)
            {
                damageDone += (remainingDamage + _health);
                Die();
                return (damageDone, true);
            }
            return (damageDone + remainingDamage, false);
        }

        public virtual void LostArmour()
        {
            ParticleManager.CreateParticleBottomUp(Assets.sparkCircleTex, _centre, new Vector2(0, 1), 0, 0, 0, 0, 600, 400, 200, 0.1f, 0.5f, 0.6f, 0, 0, Color.Orange, Color.Gray, Color.Black * 0.5f);
            for (int i = 0; i < 6; i++)
            {
                ParticleManager.CreateParticleBottomUp(Assets.debreeTex, _centre, new Vector2(0, 1), 15, 3, 2, 3, 600, 400, 200, 0.1f, 0.5f, 0.2f, 12345, 3, Color.Orange, Color.Gray, Color.Black * 0.5f);
            }
            _color = Color.Lerp(Color.White, Color.Red, 1 - (_health / _maxHealth));
        }

        public virtual void DeathParticles()
        {
            for (int i = 0; i < 6; i++)
            {
                ParticleManager.CreateParticleTopDown(Assets.sparkTex, _centre, new Vector2(0, -1), 2, 3, 1, 5, 500, 400, 100, 0.1f, 0.5f, 0.2f, 12345, 0, Color.DarkRed, Color.Red, Color.Red * 0.3f);
                ParticleManager.CreateParticleTopDown(Assets.debreeTex, _centre, new Vector2(0, -1), 2, 4, 1, 6, 550, 400, 150, 0.1f, 0.4f, 0.2f, 12345, 3, Color.DarkRed, Color.Red, Color.Red * 0.3f);
            }
        }

        public void Die()
        {
            _levelContext._scrap += _scrapValue;
            _levelContext._alienScrap += _alienScrapValue;
            _levelContext._enemiesKilled++;
            DeathParticles();
            _levelContext.enemies.Remove(this);
        }

        //Only the smallest, aka the most powerful, speed modifier applies
        public void AddSpeedModifier(float speedChange)
        {
            _speedModifier = Math.Min(speedChange, _speedModifier);
        }

        internal virtual void AttackParticles()
        {
            for (int i = 0; i < 7; i++)
            {
                ParticleManager.CreateParticleBottomUp(Assets.debreeTex, _centre, new Vector2(0, 1), 15, 1, 0.2f, 1.5f, 800, 600, 200, 0.5f, 1f, 0.7f, 12345, 3, Color.LightGray * 0.5f, Color.Gray * 0.4f, Color.Black * 0.2f);
            }
        }


        public void Draw(SpriteBatch sb)
        {
            sb.Draw(_tex, _pos, null, _color, 0, Vector2.Zero, 1f, SpriteEffects.None, 0.4f);
        }

    }
}
