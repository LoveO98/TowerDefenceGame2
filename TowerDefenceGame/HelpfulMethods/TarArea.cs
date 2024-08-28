using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TowerDefenceGame.Enemies;
using TowerDefenceGame.Managers;
using TowerDefenceGame.StateMachines.LevelState;
using TowerDefenceGame.Turrets;

namespace TowerDefenceGame.HelpfulMethods
{
    internal class TarArea : DisjointedAttackBase
    {
        
        
        float _duration;
        float _slowPower;
        float _delay = 40;
        

        public TarArea(Vector2 pos, float size, float duration, float slowPower, TurretBase source, LevelStateMachine context)
        {
            _pos = pos;
            _tex = Assets.gasBallTex;
            _range = size;
            _duration = duration;
            _slowPower = slowPower;
            _source = source;
            _context = context;
            _flammable = true;
        }

        public override void Update(GameTime gameTime)
        {
            _duration -= (float)gameTime.ElapsedGameTime.TotalMilliseconds;
            _delay -= (float)gameTime.ElapsedGameTime.TotalMilliseconds;
            if (_delay < 0)
            {
                FindTargets();
                _delay = 40;
            }
            if (_duration < 0)
            {
                _context.disjointedAttacks.Remove(this);
                return;
            }
            Vector2 tempPos = new Vector2(_rnd.Next((int)(_pos.X - _range / 2), (int)(_pos.X + _range / 2)), _rnd.Next((int)(_pos.Y - _range / 2), (int)(_pos.Y + _range / 2)));
            
        }

        public void FindTargets()
        {
            foreach(EnemyBase enemy in _context.enemies)
            {
                if (Vector2.Distance(enemy.Centre, _pos) <= _range) enemy.AddSpeedModifier(_slowPower);
            }
        }

        public override void SetOnFire()
        {
            _context.disjointedAttacks.Add(new FireArea(_pos, _range, _duration, _source, _context));
            _context.disjointedAttacks.Remove(this);
        }

        public override void Draw(SpriteBatch sb)
        {
            sb.Draw(_tex, _pos, null, new Color(Color.Black, 80), 0, new Vector2(10,10), 4.5f, SpriteEffects.None, 0.25f);
        }
    }
}
