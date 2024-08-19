using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TowerDefenceGame.Enemies;
using TowerDefenceGame.Managers;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using TowerDefenceGame.StateMachines.LevelState;
using TowerDefenceGame.Turrets;
using SharpDX.Direct2D1;
using System.Diagnostics;

namespace TowerDefenceGame.HelpfulMethods
{
    internal class ZapAttack : DisjointedAttackBase
    {
        
        int _bounce;
        EnemyBase _target;
        EnemyBase? _newTarget;
        bool _attacked = false;

        int _delay = 10;

        List<EnemyBase> _inRangeTargets = new List<EnemyBase>();
        public ZapAttack(Vector2 startPos, EnemyBase target, int bounceNR, int damage, float range, TurretBase source, LevelStateMachine context)
        {
            _tex = Assets.sparkTex;
            _pos = startPos;
            _target = target;
            _source = source;
            _context = context;
            _range = range;
            _bounce = bounceNR;
            _damageType = false;
            _damage = damage;
        }
        
        public void DamageTarget()
        {
            _attacked = true;
            float tempDmg;
            bool tempKill = false;
            ParticleManager.CreateStatParticleTopDown(_tex, _pos, 200, 0, 2, 2.2f, 0, MathF.Atan2(1, 0) - MathF.Atan2(_target.Centre.X - _pos.X, _target.Centre.Y - _pos.Y), 0, Color.Teal, new Color(Color.Teal, 20));
            (tempDmg, tempKill) = _target.TakeDamage(_damage, _damageType);
            _source._damageDealt += tempDmg;
            if (tempKill) _source._kills++;
            ParticleManager.CreateStatParticleTopDown(_tex, _target.Centre - (Vector2.Normalize(_target.Centre - _pos) * 20), 200, 0, 2, 2.2f, 0, MathF.Atan2(1, 0) - MathF.Atan2(_target.Pos.X - _pos.X, _target.Pos.Y - _pos.Y), 0, Color.Teal, new Color(Color.Teal, 20));
            if (_bounce > 0) NewBolt();
            
        }

        public override void Update(GameTime gameTime)
        {
            _delay--;
            if (_delay > 0) return;
            Debug.WriteLine("Bounces: " + _bounce);
            if (_attacked)
            {
                _context.disjointedAttacks.Remove(this);
                return;
            }
            DamageTarget();
        }

        public EnemyBase? NewTarget()
        {
            bool tempTargetCheck = false;
            foreach (EnemyBase enemy in _context.enemies)
            {
                if(Vector2.Distance(_target.Pos, enemy.Pos) <= _range)
                {
                    if (enemy == _target) continue;
                    _inRangeTargets.Add(enemy);
                    tempTargetCheck = true;
                }
            }

            if(!tempTargetCheck) return null;

            return _inRangeTargets[_rnd.Next(_inRangeTargets.Count)];
        }

        public void NewBolt()
        {
            _newTarget = NewTarget();
            if (_newTarget == null) return;
            int tempBounce = _bounce;
            tempBounce--;
            _context.disjointedAttacks.Add(new ZapAttack(_target.Centre, _newTarget, tempBounce, _damage, _range, _source, _context));
        }
    }
}
