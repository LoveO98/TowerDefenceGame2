using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using System.Text;
using System.Threading.Tasks;
using TowerDefenceGame.StateMachines.LevelState;
using TowerDefenceGame.Turrets;
using System.Xml.Serialization;

namespace TowerDefenceGame.HelpfulMethods
{
    internal abstract class DisjointedAttackBase
    {

        internal Texture2D _tex;

        internal int _damage;
        internal Vector2 _pos;

        internal bool _damageType;
        internal bool _flammable;
        internal TurretBase _source;
        internal LevelStateMachine _context;
        internal static Random _rnd = new Random();

        public float _range;

        public DisjointedAttackBase()
        {

        }

        public abstract void Update(GameTime gameTime);

        public virtual void Draw(SpriteBatch sb)
        {

        }

        public virtual void SetOnFire()
        {

        }

    }
}
