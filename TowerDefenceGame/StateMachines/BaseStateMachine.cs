using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerDefenceGame.StateMachines
{
    internal abstract class BaseStateMachine
    {

        
        internal BaseState _activeState;


        public BaseStateMachine()
        {
            
        }

        public virtual void UpdateStateMachine(GameTime gameTime)
        {
            _activeState.UpdateState(gameTime);
        }



        public virtual void DrawStateMachine(SpriteBatch sb)
        {
            _activeState.DrawState(sb);
        }
    }
}
