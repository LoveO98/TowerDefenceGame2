using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework;
using System;

namespace TowerDefenceGame.HelpfulMethods
{
    internal class InputsMKB
    {
        static KeyboardState _currentKS;
        static KeyboardState _oldKS;

        static MouseState _currentMS;
        static MouseState _oldMS;



        public InputsMKB()
        {
            _currentKS = Keyboard.GetState();
            _currentMS = Mouse.GetState();
        }

        public static void UpdateMKB()
        {
            _oldKS = _currentKS;
            _currentKS = Keyboard.GetState();
            _oldMS = _currentMS;
            _currentMS = Mouse.GetState();
        }

        public static bool IsPressed(Keys key)
        {
            return _currentKS.IsKeyDown(key);
        }


        public static bool OnPress(Keys key)
        {
            return _currentKS.IsKeyDown(key) && !_oldKS.IsKeyDown(key);
        }

        public static bool OnRelease(Keys key)
        {
            return !_currentKS.IsKeyDown(key) && _oldKS.IsKeyDown(key);
        }

        public static bool OnLeftClick()
        {
            if (_currentMS.LeftButton == ButtonState.Pressed && _oldMS.LeftButton == ButtonState.Released)
                return true;
            return false;
        }

        public static bool OnLeftRelease()
        {
            if (_currentMS.LeftButton == ButtonState.Released && _oldMS.LeftButton == ButtonState.Pressed)
                return true;
            return false;
        }

        public static bool OnRightClick()
        {
            if (_currentMS.RightButton == ButtonState.Pressed && _oldMS.RightButton == ButtonState.Released)
                return true;
            return false;
        }

        public static bool OnRightRelease()
        {
            if (_currentMS.RightButton == ButtonState.Released && _oldMS.RightButton == ButtonState.Pressed)
                return true;
            return false;
        }

        public static bool IsLeftPressed()
        {
            if (_currentMS.LeftButton == ButtonState.Pressed)
                return true;
            return false;
        }

        public static bool IsRightPressed()
        {
            if (_currentMS.RightButton == ButtonState.Pressed)
                return true;
            return false;
        }

        public static Vector2 GetMousePos()
        {
            return new Vector2(Math.Clamp(_currentMS.X, 0, 1920), Math.Clamp(_currentMS.Y, 0, 1080));
        }

        public static int ScrollWheelChange()
        {
            int scroll = _currentMS.ScrollWheelValue - _oldMS.ScrollWheelValue;
            return scroll;
        }

    }
}
