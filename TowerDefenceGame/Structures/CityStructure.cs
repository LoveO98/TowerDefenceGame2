using System;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TowerDefenceGame.Managers;
using TowerDefenceGame.StateMachines.LevelState;
using Microsoft.Xna.Framework.Media;

namespace TowerDefenceGame.Structures
{
    internal class CityStructure : StructureBase
    {
        Texture2D _buildableFootprint;
        Vector2 _buildPos1;
        Vector2 _buildPos2;
        int _ogHealth;
        public Vector2 Pos { get { return _pos; } set { _pos = value; } }
        public bool _lowHealth = false;
        public CityStructure(Vector2 pos, LevelStateMachine context, int health) : base(pos, Assets.cityBase, Assets.cityBase, health, context)
        {
            _name = "City";
            _buildableFootprint = Assets.square50x50;
            _buildPos1 = new Vector2(pos.X + 15, pos.Y + 25);
            _buildPos2 = new Vector2(pos.X + 135, pos.Y + 25);
            
            _ogHealth = _health;
        }

        public override void Update(GameTime gameTime)
        {
            return;
        }

        public void ResetCity()
        {
            _health = _ogHealth;
            AddFootprint();
            _levelContext.buildableFootprints.Add(new FootprintObject(_buildPos1, _buildableFootprint, this));
            _levelContext.buildableFootprints.Add(new FootprintObject(_buildPos2, _buildableFootprint, this));
        }

        public override void Die()
        {
            DeathParticles();
            _levelContext.YouLose();
        }
        public override void BuildTurretOnTop(StructureBase turret)
        {
            _maxHealth += turret._maxHealth;
            _health += turret._maxHealth;
            turret.PlacedOnStructure(this);
        }

        public override void TakeDamage(int damage)
        {
            _health -= damage;

            if (_health < 100 && !_lowHealth)
            {
                _lowHealth = true;
                MediaPlayer.Play(Assets.luftrauserDamaged);
                MediaPlayer.IsRepeating = true;
                MediaPlayer.Volume = .1f;
            }

            if (_health < 0 && !_dead)
            {
                _dead = true;
                Die();
            }
        }


        

    }
}
