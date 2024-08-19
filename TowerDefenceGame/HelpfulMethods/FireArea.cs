using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TowerDefenceGame.Enemies;
using TowerDefenceGame.Managers;
using TowerDefenceGame.StateMachines.LevelState;
using TowerDefenceGame.Turrets;

namespace TowerDefenceGame.HelpfulMethods
{
    internal class FireArea : DisjointedAttackBase
    {
        
        float _duration;

        float _delay = 40;

        public FireArea(Vector2 pos, float size, float duration, TurretBase source, LevelStateMachine context)
        {
            _pos = pos;
            _tex = Assets.gasBallTex;
            _range = size;
            _duration = duration;
            _source = source;
            _context = context;
        }

        public override void Update(GameTime gameTime)
        {
            _duration -= (float)gameTime.ElapsedGameTime.TotalMilliseconds;
            _delay -= (float)gameTime.ElapsedGameTime.TotalMilliseconds;
            if(_delay < 0)
            {
                FindTargets();
                Vector2 tempPos = new Vector2(_rnd.Next((int)(_pos.X - _range / 2), (int)(_pos.X + _range / 2)), _rnd.Next((int)(_pos.Y - _range / 2), (int)(_pos.Y + _range / 2)));
                ParticleManager.CreateStatParticleBottomUp(Assets.gasBallTex, tempPos, 250, 30, 2, 1, 0.5f, 0, 1, new Color(Color.Red, 20), new Color(Color.Yellow, 10));
                _delay = 40;
            }
            if (_duration < 0)
            {
                _context.disjointedAttacks.Remove(this);
                return;
            }
            
        }

        public void FindTargets()
        {
            for (int i = 0; _context.enemies.Count > i; i++)
            {
                if (Vector2.Distance(_context.enemies[i].Centre, _pos) <= _range)
                {
                    float tempDamage;
                    bool tempKill = false;
                    (tempDamage, tempKill) = _context.enemies[i].TakeDamage(5, false);
                    _source._damageDealt += tempDamage;
                    if (tempKill) _source._kills++;
                }
            }
        }

    }
}
