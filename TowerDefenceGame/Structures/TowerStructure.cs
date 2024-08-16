using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TowerDefenceGame.Managers;
using TowerDefenceGame.StateMachines.LevelState;
using TowerDefenceGame.Turrets;
using WinFormForTD;

namespace TowerDefenceGame.Structures
{
    internal class TowerStructure : StructureBase
    {
        Texture2D _buildableFootprint;
        public StructureBase _turretOnTop;
        public TurretBase _actualTurretOnTop;
        public TowerInfoForm _towerInfoForm;
        public TowerStructure(Vector2 pos, LevelStateMachine context) : base(pos, Assets.structureTower, Assets.structureTower, 300, context)
        {
            _buildableFootprint = Assets.square50x50;
            
            _name = "Tower";
            _outlineTex = Assets.towerSelectOutline;
            InitializeUI();
            _towerInfoForm.DestroyTower += Die;
        }
        
        public void InitializeUI()
        {
            _towerInfoForm = new TowerInfoForm();
            _towerInfoForm.Left = 1245 + Game1._windowPosition.X;
            _towerInfoForm.Top = 770 + Game1._windowPosition.Y;
            _towerInfoForm.lblTowerHealthValue.Text = _health.ToString() + "/" + _health.ToString();
        }

        public override void UpdateUI()
        {
            if(_turretOnTop != null)
            {
                int tempDmg;
                int tempKills;
                (tempDmg, tempKills) = _turretOnTop.GetUiInfo();
                _towerInfoForm.lblTurretDamageDealtValue.Text = tempDmg.ToString();
                _towerInfoForm.lblTurretKillsValue.Text = tempKills.ToString();
            }
            _towerInfoForm.lblTowerHealthValue.Text = _health.ToString() + "/" + _maxHealth.ToString();
            _towerInfoForm.Left = 1245 + Game1._windowPosition.X;
            _towerInfoForm.Top = 770 + Game1._windowPosition.Y;
        }
        public override void ShowUI()
        {
            _towerInfoForm.Show();
        }

        public override void HideUI()
        {
            _towerInfoForm.Hide();
        }

        public override void AddFootprint()
        {
            _levelContext.structureFootprints.Add(new FootprintObject(_pos, _structFootprint, this));
            _levelContext.buildableFootprints.Add(new FootprintObject(_pos + new Vector2(5, 5), _buildableFootprint, this));
            _levelContext._game1.DrawOnRenderTarget(_levelContext._game1._structureFootprints, _levelContext.structureFootprints);
            _levelContext._game1.DrawOnRenderTarget(_levelContext._game1._buildableFootprints, _levelContext.buildableFootprints);
        }

        public override void Update(GameTime gameTime)
        {
            return;
        }

        public override void BuildTurretOnTop(StructureBase turret)
        {
            _turretOnTop = turret;
            _maxHealth += turret._maxHealth;
            _health += turret._maxHealth;
            _turretOnTop.PlacedOnStructure(this);
        }

        public override void RemoveFootprint()
        {
            for (int i = 0; i < _levelContext.structureFootprints.Count; i++)
            {
                if (_levelContext.structureFootprints[i].Owner == this)
                    _levelContext.structureFootprints.RemoveAt(i);
            }

            for (int i = 0; i < _levelContext.buildableFootprints.Count; i++)
            {
                if (_levelContext.buildableFootprints[i].Owner == this)
                    _levelContext.buildableFootprints.RemoveAt(i);
            }
            _levelContext._game1.DrawOnRenderTarget(_levelContext._game1._structureFootprints, _levelContext.structureFootprints);
            _levelContext._game1.DrawOnRenderTarget(_levelContext._game1._buildableFootprints, _levelContext.buildableFootprints);
        }

        public override void Die()
        {
            DeathParticles();
            RemoveFootprint();
            if (_turretOnTop != null)
            {
                _turretOnTop.Die();
                _turretOnTop = null;
            }
            _towerInfoForm.DestroyTower -= Die;
            _health = 0;
            _levelContext.playerStructures.Remove(this);
        }

    }
}
