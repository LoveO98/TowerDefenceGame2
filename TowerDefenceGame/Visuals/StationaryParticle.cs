using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using TowerDefenceGame.Managers;
using System.Diagnostics;

namespace TowerDefenceGame.Visuals
{
    public class StationaryParticle
    {
        //Inputs
        protected Vector2 _pos;
        protected float _startSize;
        protected float _endSize;
        protected float _lifeTime;
        protected float _rot;
        protected float _rotSpeed;
        protected Color _startColor;
        protected Color _endColor;

        //For calculations
        protected float _sizeChange;
        protected float _remainingLife;

        protected float _lerp = 0;
        protected float _lerpChange;

        //For draw
        protected float _currentSize;
        protected Color _currentColor;
        protected Vector2 _origin;
        protected Texture2D _tex;

        public StationaryParticle(Texture2D tex, Vector2 pos, float lifeTime, float startSize, float endSize, float rot, float rotSpeed, Color startColor, Color endColor)
        {
            _pos = pos;
            _lifeTime = lifeTime;
            _startSize = startSize;
            _currentSize = startSize;
            _endSize = endSize;
            _rot = rot;
            _rotSpeed = rotSpeed;
            _startColor = startColor;
            _endColor = endColor;
            _tex = tex;

            _origin = new Vector2(tex.Width / 2, tex.Height / 2);

            _lerpChange = 1 / lifeTime;

            _sizeChange = (endSize - startSize) / lifeTime;

            _remainingLife = lifeTime;
            _currentColor = startColor;
        }

        public void Update(GameTime gameTime)
        {

            if (_remainingLife <= 0)
            {
                ParticleManager.DeleteStationaryParticle(this);
            }

            _currentSize += _sizeChange * gameTime.ElapsedGameTime.Milliseconds;
            _currentColor = Color.Lerp(_startColor, _endColor, _lerp);
            _lerp += _lerpChange * gameTime.ElapsedGameTime.Milliseconds;
            _rot += _rotSpeed * (float)gameTime.ElapsedGameTime.TotalSeconds;

            _remainingLife -= gameTime.ElapsedGameTime.Milliseconds;
        }

        public void Draw(SpriteBatch sb)
        {
            sb.Draw(_tex, _pos, null, _currentColor, _rot, _origin, _currentSize, SpriteEffects.None, 0.7f);
        }
    }
}
