using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TowerDefenceGame.Enemies;
using TowerDefenceGame.Turrets;
using TowerDefenceGame.Structures;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using TowerDefenceGame.Managers;
using System.Security.Cryptography.X509Certificates;
using System.Diagnostics;
using TowerDefenceGame.HelpfulMethods;
using WinFormForTD;
using static TowerDefenceGame.StateMachines.LevelState.LevelLibrary;
using static TowerDefenceGame.StateMachines.BaseStateLibrary;

namespace TowerDefenceGame.StateMachines.LevelState
{
    internal class LevelStateMachine : BaseStateMachine
    {
        

        public BaseMenu _baseMenuForm;
        public YouWon _youWonForm;
        public YouLost _youLostForm;

        public List<FootprintObject> turretFootprints = new List<FootprintObject>();
        public List<FootprintObject> structureFootprints = new List<FootprintObject>();
        public List<FootprintObject> buildableFootprints = new List<FootprintObject>();

        public List<EnemyBase> enemies = new List<EnemyBase>();
        public List<StructureBase> turrets = new List<StructureBase>();
        public List<StructureBase> playerStructures = new List<StructureBase>();
        public List<StructureBase> enemyStructures = new List<StructureBase>();
        public List<DisjointedAttackBase> disjointedAttacks = new List<DisjointedAttackBase>();

        public List<List<StructureBase>> allClickable = new List<List<StructureBase>>();


        public List<StructureBase> adderTarget;

        
        //private StructureBase _tempStructure;

        public CityStructure _city;
        public CityStructure City { get { return _city; } }


        internal LevelLibrary _levelLibrary;

        public bool _addingTurret = false;
        public bool _addingStructure = false;
        public bool _addingSpawner = false;

        public int _scrap = 1000;
        public int _alienScrap = 1000;
        public int _enemiesKilled = 0;

        int _buyCost = 0;

        private bool _paused = false;
        private bool _gameEnded = false;
        

        public Game1 _game1;

        public LevelStateMachine(Game1 game1)
        {
            _game1 = game1;
            _levelLibrary = new LevelLibrary(this);
            
            _baseMenuForm = new BaseMenu();
            _youWonForm = new YouWon();
            _youLostForm = new YouLost();

            _youWonForm.Left = 960 - (_youWonForm.Width / 2) + Game1._windowPosition.X;
            _youWonForm.Top = 540 - (_youWonForm.Height / 2) + Game1._windowPosition.Y;
            _youLostForm.Left = 960 - (_youLostForm.Width / 2) + Game1._windowPosition.X;
            _youLostForm.Top = 540 - (_youLostForm.Height / 2) + Game1._windowPosition.Y;

            turretFootprints.Add(new FootprintObject(Vector2.Zero, Assets.noNoZoneUI, null));
            structureFootprints.Add(new FootprintObject(Vector2.Zero, Assets.noNoZoneUI, null));
            
            allClickable.Add(turrets);
            allClickable.Add(playerStructures);
            allClickable.Add(enemyStructures);
        }

        public void InitializeLevelMachine(StateKey key)
        {
            _gameEnded = false;
            _activeState = _levelLibrary.GetState(key);
            _activeState.EnterState();
            turretFootprints.Add(new FootprintObject(Vector2.Zero, Assets.noNoZoneUI, null));
            structureFootprints.Add(new FootprintObject(Vector2.Zero, Assets.noNoZoneUI, null));
            _baseMenuForm.buyStructure += AddStructure;
            _baseMenuForm.changeTargeting += OnChangeTarget;
            _baseMenuForm.unlockTargeting += OnUnlockGlobal;
            _baseMenuForm.Left = 1605 + Game1._windowPosition.X;
            _baseMenuForm.Top = 35 + Game1._windowPosition.Y;
            
            _baseMenuForm.Show();

            


            
            _game1.DrawOnRenderTarget(_game1._structureFootprints, structureFootprints);
            _game1.DrawOnRenderTarget(_game1._turretFootprints, turretFootprints);
            _game1.DrawOnRenderTarget(_game1._buildableFootprints, buildableFootprints);
        }

        public void OnUnlockGlobal()
        {
            foreach(TurretBase turret in turrets)
            {
                turret._globalLock = false;
            }
        }

        public void OnChangeTarget()
        {
            foreach(TurretBase turret in turrets)
            {
                if (!turret._globalLock)
                {
                    turret.ChangeTargetingMode(_baseMenuForm.cbBaseTargetingModes.SelectedIndex);
                }
            }
        }

        public override void UpdateStateMachine(GameTime gameTime)
        {
            if (!_paused && !_gameEnded) _activeState.UpdateState(gameTime);

            UpdateSelector();
            UpdateAdder();
            UpdateUI();

            if (InputsMKB.OnPress(Keys.Space)) _paused = !_paused;

            if(enemies.Count == 0)
            {
                int tempWinCheck = 0;
                foreach(EnemySpawnStructure spawner in enemyStructures)
                {
                    if (spawner._inactive) tempWinCheck++;
                }
                if (tempWinCheck >= enemyStructures.Count) YouWin();
            }
        }

        public void UpdateUI()
        {
            _baseMenuForm.lblBaseScrapValue.Text = _scrap.ToString();
            _baseMenuForm.lblBaseAlienScrapValue.Text = _alienScrap.ToString();
            _baseMenuForm.lblBaseEnemiesKilledValue.Text = _enemiesKilled.ToString();
            _baseMenuForm.lblBaseHealthValue.Text = _city.Health.ToString();
        }
        
        public void ExitMachine()
        {
            _baseMenuForm.buyStructure -= AddStructure;
            _baseMenuForm.Hide();
            _youWonForm.Hide();
            _youLostForm.Hide();
            buildableFootprints.Clear();
            structureFootprints.Clear();
            turretFootprints.Clear();
            enemies.Clear();
            playerStructures.Clear();
            turrets.Clear();
            enemyStructures.Clear();
            disjointedAttacks.Clear();
            StructureSelector._selectedStructure = null;
            _activeState.ExitState();
            _game1.DrawOnRenderTarget(_game1._structureFootprints, structureFootprints);
            _game1.DrawOnRenderTarget(_game1._turretFootprints, turretFootprints);
            _game1.DrawOnRenderTarget(_game1._buildableFootprints, buildableFootprints);
        }

        public void YouWin()
        {
            _gameEnded = true;
            _youWonForm.lblTotalKillsValue.Text = _enemiesKilled.ToString();
            _youWonForm.Show();
        }

        public void YouLose()
        {
            _gameEnded = true;
            _youLostForm.lblTotalKillsValue.Text = _enemiesKilled.ToString();
            _youLostForm.Show();
        }

        public void UpdateAdder()
        {
            if (!_addingStructure) return;
            StructureAdder.UpdateAdder();
            if (InputsMKB.OnLeftClick() && StructureAdder._canPlace)
            {
                StructureAdder.PlaceStructure(adderTarget);
                _scrap -= _buyCost;
                _addingStructure = false;
            }
            if (InputsMKB.OnRightClick()) _addingStructure = false;
        }

        public void UpdateSelector()
        {
            if (_addingStructure) return;
            StructureSelector.UpdateSelectorPos();
            if (!StructureSelector._lockedSelection)
            {
                foreach (List<StructureBase> structureList in allClickable)
                {
                    foreach (StructureBase structure in structureList)
                    {
                        StructureSelector.ScanThroughStructures(structure);
                    }
                }
            }
        }

        public void AddStructure(int nr)
        {
            switch (nr)
            {
                case 1:
                    if (_scrap < TurretShort.BuyCost) return;
                    _buyCost = TurretShort.BuyCost;
                    _addingStructure = true;
                    adderTarget = turrets;
                    StructureAdder.SelectStructure(new TurretShort(InputsMKB.GetMousePos(), this));
                    break;

                case 2:
                    if (_scrap < TurretMedium.BuyCost) return;
                    _buyCost = TurretMedium.BuyCost;
                    _addingStructure = true;
                    adderTarget = turrets;
                    StructureAdder.SelectStructure(new TurretMedium(InputsMKB.GetMousePos(), this));
                    break;

                case 3:
                    if (_scrap < TurretLong.BuyCost) return;
                    _buyCost = TurretLong.BuyCost;
                    _addingStructure = true;
                    adderTarget = turrets;
                    StructureAdder.SelectStructure(new TurretLong(InputsMKB.GetMousePos(), this));
                    break;

                case 4:
                    //if(can afford)
                    if (_scrap < TowerStructure.BuyCost) return;
                    _buyCost = TowerStructure.BuyCost;
                    _addingStructure = true;
                    adderTarget = playerStructures;
                    StructureAdder.SelectStructure(new TowerStructure(InputsMKB.GetMousePos(), this));
                    break;

            }
        }

        public override void DrawStateMachine(SpriteBatch sb)
        {
            DrawPlayerStructs(sb);
            DrawEnemyStructs(sb);
            DrawTurrets(sb);
            DrawEnemies(sb);
            DrawAttacks(sb);
            _activeState.DrawState(sb);
            if (_addingStructure) StructureAdder.DrawUnit(sb);
            StructureSelector.DrawSelectOutline(sb);
            sb.Draw(Assets.genericLevelBackground, Vector2.Zero, null, Color.White, 0, Vector2.Zero, 1f, SpriteEffects.None, 0.1f);
        }


        public void UpdateEnemies(GameTime gameTime)
        {
            for (int i = 0; i < enemies.Count; i++)
            {
                enemies[i].Update(gameTime);
            }
        }

        public void UpdateTurrets(GameTime gameTime)
        {
            for (int i = 0; i < turrets.Count; i++)
            {
                turrets[i].Update(gameTime);
            }
        }

        public void UpdateEnemyStructs(GameTime gameTime)
        {
            for (int i = 0; i < enemyStructures.Count; i++)
            {
                enemyStructures[i].Update(gameTime);
            }
        }

        public void UpdateAttacks(GameTime gameTime)
        {
            for (int i = 0; i < disjointedAttacks.Count; i++)
            {
                disjointedAttacks[i].Update(gameTime);
            }
        }

        public void DrawEnemies(SpriteBatch sb)
        {
            for (int i = 0; i < enemies.Count; i++)
            {
                enemies[i].Draw(sb);
            }
        }


        public void DrawTurrets(SpriteBatch sb)
        {
            for (int i = 0; i < turrets.Count; i++)
            {
                turrets[i].Draw(sb);
            }
        }

        public void DrawPlayerStructs(SpriteBatch sb)
        {
            for (int i = 0; i < playerStructures.Count; i++)
            {
                playerStructures[i].Draw(sb);
            }
        }

        public void DrawEnemyStructs(SpriteBatch sb)
        {
            for (int i = 0; i < enemyStructures.Count; i++)
            {
                enemyStructures[i].Draw(sb);
            }
        }

        public void DrawAttacks(SpriteBatch sb)
        {
            for (int i = 0; i < disjointedAttacks.Count; i++)
            {
                disjointedAttacks[i].Draw(sb);
            }
        }
    }
}
