using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using TowerDefenceGame.Managers;
using TowerDefenceGame.Structures;

namespace TowerDefenceGame.HelpfulMethods
{
    internal class StructureSelector
    {
        private static Texture2D _outline = Assets.turretSelectOutline;
        private static Vector2 _pos;
        private static Vector2 _centering = new Vector2(10,10);
        public static StructureBase _selectedStructure;
        public static bool _lockedSelection = false;
        public static bool _selectionOpen = false;
        public StructureSelector()
        {

        }

        public static void UpdateSelectorPos()
        {
            if(_selectedStructure != null)
            {
                _selectedStructure.UpdateUI();
                if (InputsMKB.OnLeftClick() && !_selectionOpen)
                {
                    _lockedSelection = true;
                    _selectionOpen = true;
                    _selectedStructure.ShowUI();
                }
                if (InputsMKB.OnRightClick() || _selectedStructure.Health <= 0) UnlockSelection();
            }
            
            if(!_lockedSelection) _selectedStructure = null;

            _pos = InputsMKB.GetMousePos();
        }

        public static void UnlockSelection()
        {
            _lockedSelection = false;
            _selectionOpen = false;
            _selectedStructure.HideUI();
            _selectedStructure = null;
        }

        public static void ScanThroughStructures(StructureBase structure)
        {
            if (Vector2.Distance(_pos, structure.StructCentre) <= 25 && structure.Name != "Tower" && structure.Name != "Enemy Spawner" && structure.Name != "City")
            {
                _selectedStructure = structure;
                _outline = _selectedStructure._outlineTex;
                _centering = new Vector2((_outline.Width - _selectedStructure.StructFootprint.Width)/2, (_outline.Height - _selectedStructure.StructFootprint.Height) / 2);
            }
            else if (Vector2.Distance(_pos, structure.StructCentre) <= 35 && structure.Name == "Tower" && Vector2.Distance(_pos, structure.StructCentre) > 15)
            {
                _selectedStructure = structure;
                _outline = _selectedStructure._outlineTex;
                _centering = new Vector2((_outline.Width - _selectedStructure.StructFootprint.Width) / 2, (_outline.Height - _selectedStructure.StructFootprint.Height) / 2);
            }
            else if (Vector2.Distance(_pos, structure.StructCentre) <= 55 && structure.Name == "Enemy Spawner")
            {
                _selectedStructure = structure;
                _outline = _selectedStructure._outlineTex;
                _centering = new Vector2((_outline.Width - _selectedStructure.StructFootprint.Width) / 2, (_outline.Height - _selectedStructure.StructFootprint.Height) / 2);
            }
        }

        public static void DrawSelectOutline(SpriteBatch sb)
        {
            if(_selectedStructure != null)
                sb.Draw(_outline, _selectedStructure.Position - _centering, null, Color.White, 0, Vector2.Zero, 1f, SpriteEffects.None, 0.2f + _selectedStructure.LayerModif);
        }
    }
}
