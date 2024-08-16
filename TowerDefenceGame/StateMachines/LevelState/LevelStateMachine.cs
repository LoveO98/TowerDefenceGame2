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

namespace TowerDefenceGame.StateMachines.LevelState
{
    internal class LevelStateMachine : BaseStateMachine
    {
        BaseState _activeLevelState;

        BaseMenu _baseMenuForm;

        public List<FootprintObject> turretFootprints = new List<FootprintObject>();
        public List<FootprintObject> structureFootprints = new List<FootprintObject>();
        public List<FootprintObject> buildableFootprints = new List<FootprintObject>();

        public List<EnemyBase> enemies = new List<EnemyBase>();
        public List<StructureBase> turrets = new List<StructureBase>();
        public List<StructureBase> playerStructures = new List<StructureBase>();
        public List<StructureBase> enemyStructures = new List<StructureBase>();

        public List<List<StructureBase>> allClickable = new List<List<StructureBase>>();


        public List<StructureBase> adderTarget;

        
        //private StructureBase _tempStructure;

        CityStructure _city;
        public CityStructure City { get { return _city; } }


        internal LevelLibrary _levelLibrary;

        public bool _addingTurret = false;
        public bool _addingStructure = false;
        public bool _addingSpawner = false;

        public int _scrap;
        public int _alienScrap;
        public int _enemiesKilled = 0;

        public string _listName;

        public BaseState ActiveLevelState { get { return _activeLevelState; } set { _activeLevelState = value; } }

        public Game1 _game1;

        public LevelStateMachine(Game1 game1)
        {
            _levelLibrary = new LevelLibrary(this);
            _activeState = _levelLibrary.GetLevelState(LevelKey.sandbox);
            _activeState.EnterState();
            _game1 = game1;
            _baseMenuForm = new BaseMenu();
            _baseMenuForm.Show();
            _baseMenuForm.Left = 1605 + Game1._windowPosition.X;
            _baseMenuForm.Top = 35 + Game1._windowPosition.Y;
            _baseMenuForm.buyStructure += AddStructure;
            turretFootprints.Add(new FootprintObject(Vector2.Zero, Assets.noNoZoneUI, null));
            structureFootprints.Add(new FootprintObject(Vector2.Zero, Assets.noNoZoneUI, null));
            _game1.DrawOnRenderTarget(_game1._structureFootprints, structureFootprints);
            _game1.DrawOnRenderTarget(_game1._turretFootprints, turretFootprints);
            allClickable.Add(turrets);
            allClickable.Add(playerStructures);
            allClickable.Add(enemyStructures);
        }

        public void InitializeLevelMachine()
        {
            
        }

        public override void UpdateStateMachine(GameTime gameTime)
        {
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
            
            

            _activeState.UpdateState(gameTime);
            

            //if (_baseMenuForm._buyTurret)
            //{
            //    switch (_baseMenuForm._turretNR)
            //    {
            //        case 1:
            //            //if(can afford)
            //            _addingStructure = true;
            //            StructureAdder.SelectStructure(new TurretShort(InputsMKB.GetMousePos(), false, this));
            //            break;

            //        case 2:
            //            //if(can afford)
            //            _addingStructure = true;
            //            StructureAdder.SelectStructure(new TurretShort2(InputsMKB.GetMousePos(), false, this));
            //            break;

            //        case 3:
            //            //if(can afford)
            //            _addingStructure = true;
            //            StructureAdder.SelectStructure(new TurretLong(InputsMKB.GetMousePos(), false, this));
            //            break;
            //    }
                
            //}

            if (_addingStructure)
            {
                StructureAdder.UpdateAdder();
                if (InputsMKB.OnLeftClick() && StructureAdder._canPlace)
                {
                    StructureAdder.PlaceStructure(adderTarget, _listName);

                    _addingStructure = false;
                }
                if (InputsMKB.OnRightClick()) _addingStructure = false;
            }


            if (_baseMenuForm._exitLevel) Debug.WriteLine("ExitLevel");
        }

        public void AddStructure(int nr)
        {
            switch (nr)
            {
                case 1:
                    //if(can afford)
                    _addingStructure = true;
                    adderTarget = turrets;
                    _listName = "turrets";
                    StructureAdder.SelectStructure(new TurretShort(InputsMKB.GetMousePos(), this));
                    break;

                case 2:
                    //if(can afford)
                    _addingStructure = true;
                    adderTarget = turrets;
                    _listName = "turrets";
                    StructureAdder.SelectStructure(new TurretShort2(InputsMKB.GetMousePos(), this));
                    break;

                case 3:
                    //if(can afford)
                    _addingStructure = true;
                    adderTarget = turrets;
                    _listName = "turrets";
                    StructureAdder.SelectStructure(new TurretLong(InputsMKB.GetMousePos(), this));
                    break;

                case 4:
                    //if(can afford)
                    _addingStructure = true;
                    adderTarget = playerStructures;
                    _listName = "playerStructs";
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
            if (_addingStructure) StructureAdder.DrawUnit(sb);
            StructureSelector.DrawSelectOutline(sb);
            sb.Draw(Assets.genericLevelBackground, Vector2.Zero, null, Color.White, 0, Vector2.Zero, 1f, SpriteEffects.None, 0.1f);
        }

        public void ExitLevel()
        {

        }

        public void SetCityLocation(Vector2 newLocation)
        {
            if (_city != null)
            {
                _city.Pos = newLocation;
            }
            else
            {
                _city = new CityStructure(newLocation, this);
            }
        }


        //public void DrawDot(SpriteBatch sb)
        //{
        //    sb.Draw(Assets.pixelCircle, dotPos, Color.White);
        //}

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
    }
}
