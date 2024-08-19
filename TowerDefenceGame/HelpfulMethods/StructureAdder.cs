using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using TowerDefenceGame.Enemies;
using TowerDefenceGame.Managers;
using TowerDefenceGame.StateMachines.LevelState;
using TowerDefenceGame.Structures;

namespace TowerDefenceGame.HelpfulMethods
{
    internal class StructureAdder
    {
        private static Texture2D _unitTex;
        private static Vector2 _pos;
        private static Vector2 _centering;
        private static Color _yesColor = new Color(Color.White, 70);
        private static Color _noColor = new Color(Color.Red, 70);
        public static Color _color = _yesColor;
        private static StructureBase _structure;
        
        static Game1 _game1;

        public static bool _canPlace;
        internal static bool _onTower;
        private static StructureBase _tower;

        public StructureAdder(Game1 game1)
        {
            _game1 = game1;
        }

        public static void UpdateAdder()
        {
            _pos = InputsMKB.GetMousePos();
            _structure.Position = _pos - _centering;
            _structure.StructCentre = _pos;
            _structure.UpdateHitboxPos();
            if(_structure.Name == "Tower")
            {
                if (_game1.NotObstructedByTurret(_structure) && _game1.NotObstructedByStructure(_structure))
                {
                    _color = _yesColor;
                    _canPlace = true;
                }
                else
                {
                    _color = _noColor;
                    _canPlace = false;
                }
            }
            else if(_structure.Name == "Enemy Spawner")
            {
                if (_game1.NotObstructedByTurret(_structure))
                {
                    _color = _yesColor;
                    _canPlace = true;
                }
                else
                {
                    _color = _noColor;
                    _canPlace = false;
                }
            }
            else
            {
                if (_game1.NotObstructedByTurret(_structure))
                {
                    if (_game1.NotObstructedByStructure(_structure))
                    {
                        _color = _yesColor;
                        _canPlace = true;
                        _onTower = false;
                    }
                    else if (_game1.OnBuildableArea(_structure))
                    {
                        _color = _yesColor;
                        _canPlace = true;
                        _onTower = true;
                        bool tempTowerFound = false;
                        foreach(StructureBase tower in _structure._levelContext.playerStructures)
                        {
                            if(Vector2.Distance(tower._structCentre, _pos) <= 25)
                            {
                                _tower = tower;
                                tempTowerFound = true;
                                break;
                            }
                        }
                        if (!tempTowerFound) _tower = _structure._levelContext._city;
                    }
                    else
                    {
                        _color = _noColor;
                        _canPlace = false;
                        _onTower = false;
                    }
                }
                else
                {
                    _color = _noColor;
                    _canPlace = false;
                    _onTower = false;
                }
            }
        }

        public static void PlaceStructure(List<StructureBase> targetList)
        {
            targetList.Add(_structure);
            _structure.AddFootprint();
            if (_onTower) _tower.BuildTurretOnTop(_structure);
            _structure = null;
            var instance = Assets.placeStructureThump.CreateInstance();
            instance.Volume = 0.1f;
            instance.Play();
        }

        public static void SelectStructure(StructureBase structure)
        {
            _structure = structure;
            _unitTex = structure.StructTex;
            _centering = new Vector2(structure.StructFootprint.Width / 2, structure.StructFootprint.Height / 2);
        }

        public static void DrawUnit(SpriteBatch sb)
        {
            sb.Draw(_unitTex, _pos - _centering, null, _color, 0, Vector2.Zero, 1f, SpriteEffects.None, 0.9f);
        }

    }
}
