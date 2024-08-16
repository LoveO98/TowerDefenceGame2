using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormForTD;

namespace TowerDefenceGame.StateMachines.GameStates
{
    internal class MenuState : BaseState
    {
        internal MainMenuForm _mainMenu;
        int _lvlNr;

        public MenuState(GameStateMachine machine, GameStateLibrary library) : base(machine, library)
        {
            
        }

        public override void EnterState()
        {
            _mainMenu.ExitGame += OnExitGame;
            _mainMenu.StartLevel += OnLevelPicked;
        }

        public override void ExitState()
        {
            _mainMenu.ExitGame -= OnExitGame;
        }

        public override void UpdateState(GameTime gameTime)
        {
            //run state
        }


        public override void CheckSwitchState()
        {
            switch (_lvlNr)
            {
                case 0:
                    SwitchState()
            }
        }

        public void OnLevelPicked(int lvlNr)
        {
            _lvlNr = lvlNr;
            CheckSwitchState();
        }

        public void OnExitGame()
        {
            Game1.QuitGame();
        }

    }
}
