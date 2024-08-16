using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace TowerDefenceGame.StateMachines.LevelState.Tutorial
{
    internal class TutorialIntro : BaseState
    {

        public TutorialIntro(LevelStateMachine machine, LevelLibrary library) : base(machine, library)
        {

        }


        public override void EnterState()
        {
            throw new NotImplementedException();
        }

        public override void UpdateState(GameTime gameTime)
        {

        }


        public override void CheckSwitchState()
        {
            throw new NotImplementedException();
        }

        public override void ExitState()
        {
            throw new NotImplementedException();
        }

    }
}
