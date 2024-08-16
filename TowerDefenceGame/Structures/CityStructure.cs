using System;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TowerDefenceGame.Managers;
using TowerDefenceGame.StateMachines.LevelState;

namespace TowerDefenceGame.Structures
{
    internal class CityStructure : StructureBase
    {
        Texture2D _buildableFootprint;
        Vector2 _buildPos1;
        Vector2 _buildPos2;
        public Vector2 Pos { get { return _pos; } set { _pos = value; } }
        public CityStructure(Vector2 pos, LevelStateMachine context) : base(pos, Assets.cityBase, Assets.square200x100, 500, context)
        {
            _buildableFootprint = Assets.square50x50;
            _buildPos1 = new Vector2(pos.X + 15, pos.Y + 25);
            _buildPos2 = new Vector2(pos.X + 135, pos.Y + 25);
            _levelContext.buildableFootprints.Add(new FootprintObject(_buildPos1, _buildableFootprint, this));
            _levelContext.buildableFootprints.Add(new FootprintObject(_buildPos2, _buildableFootprint, this));
        }

        public override void Update(GameTime gameTime)
        {
            return;
        }

        //public override void TakeDamage(int damage)
        //{

        //}


        public void OnClick()
        {
            //Call the forms to open the city panel
        }

        //No remove buildable footprint method since you can't remove the city during normal gameplay. Only removed when level is redrawn when started.
    }
}
