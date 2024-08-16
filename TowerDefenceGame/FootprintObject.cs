using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TowerDefenceGame.Structures;

namespace TowerDefenceGame
{
    internal class FootprintObject
    {
        Vector2 _pos;
        Texture2D _tex;
        StructureBase? _owner;
        public StructureBase Owner { get { return _owner; } }
        public Vector2 Pos { get { return _pos; } }

        public FootprintObject(Vector2 pos, Texture2D tex, StructureBase? owner)
        {
            _pos = pos;
            _tex = tex;
            _owner = owner;
        }

        public void Draw(SpriteBatch sb)
        {
            sb.Draw(_tex, _pos, Color.White);

        }
    }
}
