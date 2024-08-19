using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormForTD;
using Microsoft.Xna.Framework.Media;
using TowerDefenceGame.Managers;
using static TowerDefenceGame.StateMachines.BaseStateLibrary;

namespace TowerDefenceGame.StateMachines.GameStates
{
    internal class MenuState : BaseState
    {
        internal MainMenuForm _mainMenu;
        

        public MenuState(GameStateMachine machine, GameStateLibrary library) : base(machine, library)
        {
            
            _mainMenu = new MainMenuForm();
            _mainMenu.Left = 960 - (_mainMenu.Width / 2) + Game1._windowPosition.X;
            _mainMenu.Top = 540 - (_mainMenu.Height / 2) + Game1._windowPosition.Y;
        }

        public override void EnterState()
        {
            MediaPlayer.Play(Assets.menuMusic);
            MediaPlayer.IsRepeating = false;
            MediaPlayer.Volume = .02f;
            _mainMenu.ExitGame += OnExitGame;
            _mainMenu.StartLevel += OnLevelPicked;
            
            _mainMenu.Show();
        }

        public override void ExitState()
        {
            _mainMenu.Hide();
            _mainMenu.ExitGame -= OnExitGame;
            _mainMenu.StartLevel -= OnLevelPicked;
        }

        public override void UpdateState(GameTime gameTime)
        {
            //run state
        }
        
        public void OnLevelPicked(int lvlNr)
        {

            switch (lvlNr)
            {
                
                case 1:
                    _library._selectedLevel = StateKey.level1;
                    break;

                case 2:
                    _library._selectedLevel = StateKey.level2;
                    break;

                case 3:
                    _library._selectedLevel = StateKey.sandbox;
                    break;


            }

            SwitchState(_library.GetState(StateKey.runLevel));
        }

        public void OnExitGame()
        {
            Game1.QuitGame();
        }

        public override void DrawState(SpriteBatch sb)
        {
            sb.Draw(Assets.menuBackground, Vector2.Zero, Color.White);
        }

    }
}
