using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TowerDefenceGame.Managers;
using TowerDefenceGame.StateMachines.LevelState;
using System.Windows.Forms;
using TowerDefenceGame.Turrets;

namespace TowerDefenceGame.Structures
{
    internal abstract class StructureBase
    {

        protected Vector2 _pos;
        public Vector2 Position { get { return _pos; } set { _pos = value; } }

        internal float _layerModif = 0;
        public float LayerModif { get { return _layerModif; } }

        //Used for pictures in the UI etc.
        internal Texture2D _tex;
        //Using a seperate image as the foorprint for the rendertarget since i don't actually want pixel perfect collisions on the texture since the turrets have slighlty different texture outlines
        //This avoids things like the barrel of a gun sticking out slightly changing the way you can place turrets
        internal Texture2D _structFootprint;
        public Texture2D StructTex {  get { return _tex; } }
        public Texture2D StructFootprint { get { return _structFootprint; } }
        public LevelStateMachine _levelContext;

        internal Texture2D _outlineTex;
        public Texture2D OutlineTex { get { return _outlineTex; } }

        internal string _name;
        public string Name { get { return _name; } }

        protected Color _color = Color.White;
        protected Rectangle _hitBox;
        public Rectangle HitBox { get { return _hitBox; } }
        
        internal bool _dead = false;

        internal int _health;
        internal int _maxHealth;
        public int Health { get { return _health; } }

        internal Vector2 _structCentre;
        public Vector2 StructCentre { get { return _structCentre;} set { _structCentre = value; } }

        public StructureBase(Vector2 pos, Texture2D tex, Texture2D structFootprint, int health, LevelStateMachine context)
        {
            _pos = pos;
            _tex = tex;
            _structFootprint = structFootprint;
            _structCentre = _pos + new Vector2(_structFootprint.Width/2, _structFootprint.Height/2);
            _levelContext = context;
            _health = health;
            _maxHealth = _health;
            _hitBox = new Rectangle((int)_pos.X, (int)_pos.Y, _structFootprint.Width, _structFootprint.Height);
        }

        public virtual void AddFootprint()
        {
            _levelContext.structureFootprints.Add(new FootprintObject(_pos, _structFootprint, this));
            _levelContext._game1.DrawOnRenderTarget(_levelContext._game1._structureFootprints, _levelContext.structureFootprints);
        }

        public virtual void ShowUI()
        {

        }

        public virtual void HideUI()
        {

        }

        public virtual void UpdateUI()
        {

        }

        public virtual void BuildTurretOnTop(StructureBase turret)
        {
            
        }
        public virtual void PlacedOnStructure(StructureBase structure)
        {
            
        }

        public virtual (int,int) GetUiInfo()
        {
            int temp1 = 0;
            int temp2 = 0;
            return (temp1,temp2);
        }

        public void UpdateHitboxPos()
        {
            _hitBox.X = (int)_pos.X;
            _hitBox.Y = (int)_pos.Y;
        }

        public abstract void Update(GameTime gameTime);

        public void TakeDamage(int damage)
        {
            _health -= damage;
            if (_health < 0 && !_dead)
            {
                _dead = true;
                Die();
            }
        }
        
        //This doesn't work for the city
        public virtual void Die()
        {
            DeathParticles();
            RemoveFootprint();
            _health = 0;
            _levelContext.playerStructures.Remove(this);
        }

        public virtual void RemoveFootprint()
        {
            for (int i = 0; i < _levelContext.structureFootprints.Count; i++)
            {
                if (_levelContext.structureFootprints[i].Owner == this)
                    _levelContext.structureFootprints.RemoveAt(i);
            }
            _levelContext._game1.DrawOnRenderTarget(_levelContext._game1._structureFootprints, _levelContext.structureFootprints);
        }

        public virtual void DeathParticles()
        {
            for (int i = 0; i < 7; i++)
            {
                ParticleManager.CreateParticleBottomUp(Assets.debreeTex, _structCentre, new Vector2(0, 1), 15, 2, 1, 1.5f, 1000, 600, 400, 0.5f, 1.5f, 0.7f, 12345, 3, Color.LightGray, Color.Gray, new Color(Color.Black, 70));
            }

            for (int i = 0; i < 15; i++)
            {
                ParticleManager.CreateParticleBottomUp(Assets.gasBallTex, _structCentre, new Vector2(0, 1), 15, 3, 1, 1, 1400, 1000, 400, 0.5f, 2f, 0.7f, 12345, 3, Color.Gray, Color.Black, new Color(Color.Black, 40));
            }
        }

        public virtual void Draw(SpriteBatch sb)
        {
            sb.Draw(_tex, _pos, null, _color, 0, Vector2.Zero, 1f, SpriteEffects.None, 0.25f);
        }

    }
}
