using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TowerDefenceGame.Managers;

namespace TowerDefenceGame.Visuals
{
    public class Particle
    {
        //Inputs
        protected Vector2 _dir;
        protected float _speed;
        protected float _drag;
        protected float _lifeTime;
        protected float _startSize;
        protected float _midSize;
        protected float _endSize;
        protected float _sizeTime1;
        protected float _sizeTime2;
        protected float _rot;
        protected float _rotSpeed;
        protected Color _startColor;
        protected Color _midColor;
        protected Color _endColor;


        //For calculations
        protected float _sizeChange1;
        protected float _sizeChange2;
        protected float _remainingLife;

        protected float _lerp1 = 0;
        protected float _lerp2 = 0;
        protected float _lerpChange1;
        protected float _lerpChange2;

        
        //For drawing
        protected float _currentSize;
        protected Vector2 _currentPos;
        protected Color _currentColor;
        protected Vector2 _origin;
        protected Texture2D _tex;

        

        public Particle(Texture2D tex, Vector2 pos, Vector2 dir, float speed, float drag, float lifeTime, float sizeTime1, float sizeTime2, float startSize, float midSize, float endSize, float rot, float rotSpeed, Color startColor, Color midColor, Color endColor)
        {
            _dir = dir;
            _speed = speed;
            _drag = drag;
            _lifeTime = lifeTime;
            _startSize = startSize;
            _currentSize = startSize;
            _midSize = midSize;
            _endSize = endSize;
            _sizeTime1 = sizeTime1;
            _sizeTime2 = sizeTime2;
            _rot = rot;
            _rotSpeed = rotSpeed;
            _startColor = startColor;
            _midColor = midColor;
            _endColor = endColor;
            _tex = tex;

            _origin = new Vector2(tex.Width/2 , tex.Height/2);

            _lerpChange1 = 1 / sizeTime1;
            _lerpChange2 = 1 / sizeTime2;

            _sizeChange1 = (midSize - startSize) / sizeTime1;
            _sizeChange2 = (endSize - midSize) / sizeTime2;

            _remainingLife = lifeTime;
            _currentPos = pos;


            

            _currentColor = startColor;
        }

        public void Update(GameTime gameTime)
        {

            if (_remainingLife <= 0)
            {
                ParticleManager.DeleteMovingParticle(this);
            }
            
            
            //The different lifecycles of the particle
            if (_lifeTime - _sizeTime1 < _remainingLife)
            {
                _currentSize += _sizeChange1 * gameTime.ElapsedGameTime.Milliseconds;
                _currentColor = Color.Lerp(_startColor, _midColor, _lerp1);
                _lerp1 += _lerpChange1 * gameTime.ElapsedGameTime.Milliseconds;
            }
            else
            {
                _currentSize += _sizeChange2 * gameTime.ElapsedGameTime.Milliseconds;
                _currentColor = Color.Lerp(_midColor, _endColor, _lerp2);
                _lerp2 += _lerpChange2 * gameTime.ElapsedGameTime.Milliseconds;
            }
            
            //Pos Changes
            _speed = MathF.Abs(_speed - _drag / gameTime.ElapsedGameTime.Milliseconds);
            _currentPos += _speed * _dir;
            _rot += _rotSpeed * (float)gameTime.ElapsedGameTime.TotalSeconds;
            _remainingLife -= gameTime.ElapsedGameTime.Milliseconds;
        }

        public void Draw(SpriteBatch sb)
        {
            sb.Draw(_tex, _currentPos, null, _currentColor, _rot, _origin, _currentSize, SpriteEffects.None, 0.7f);
        }


        

    }
}
