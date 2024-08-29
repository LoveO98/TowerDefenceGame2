using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using TowerDefenceGame.Managers;
using TowerDefenceGame.HelpfulMethods;
using TowerDefenceGame.Structures;
using TowerDefenceGame.StateMachines.LevelState;
using TowerDefenceGame.StateMachines.GameStates;
using TowerDefenceGame.StateMachines;

namespace TowerDefenceGame
{
    internal class Game1 : Game
    {
        GraphicsDeviceManager _graphics;
        SpriteBatch _spriteBatch;


        
        private ParticleManager _particleManager;

        private Random rand = new Random();

        public RenderTarget2D _turretFootprints;
        public RenderTarget2D _structureFootprints;
        public RenderTarget2D _buildableFootprints;

        public static Point _windowPosition;

        int counter = 0;
        int counter2 = 0;
        Vector2 dotPos = new Vector2(600, 50);

        GameStateMachine _gameManager;
        LevelStateMachine _levelManager;
        RunningLevelState _levelRunner;
        public StructureAdder _structureAdder;

        static Game1 _thisGame;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
            _thisGame = this;
        }

        protected override void Initialize()
        {
            _graphics.PreferredBackBufferWidth = 1920;
            _graphics.PreferredBackBufferHeight = 1080;
            _graphics.ApplyChanges();
            _windowPosition = Window.Position;
            base.Initialize();
            _turretFootprints = new RenderTarget2D(GraphicsDevice, 1920, 1080);
            _structureFootprints = new RenderTarget2D(GraphicsDevice, 1920, 1080);
            _buildableFootprints = new RenderTarget2D(GraphicsDevice, 1920, 1080);
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            Assets.LoadTextures(Content);
            _particleManager = new ParticleManager();
            _levelManager = new LevelStateMachine(this);
            _gameManager = new GameStateMachine();
            //This is my attempt at avoiding having too many connections between the states
            //This was added really late into the project, so while a redesign probably would have been better I did not have the time
            _levelRunner = (RunningLevelState)_gameManager._stateLibrary.StateDictionary[BaseStateLibrary.StateKey.runLevel];
            _levelRunner._levelStateMachine = _levelManager;
            _structureAdder = new StructureAdder(this);
        }
        
        protected override void Update(GameTime gameTime)
        {
            counter++;
            InputsMKB.UpdateMKB();

            if (InputsMKB.OnPress(Keys.F)) Debug.WriteLine("dropped frames: " + (counter - counter2) + "  total frames: " + counter);

            _gameManager.UpdateStateMachine(gameTime);
            //_levelManager.UpdateStateMachine(gameTime);
            _particleManager.Update(gameTime);


            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);
            _spriteBatch.Begin(SpriteSortMode.FrontToBack);
            
            _particleManager.Draw(_spriteBatch);
            _gameManager.DrawStateMachine(_spriteBatch);
            _spriteBatch.Draw(_turretFootprints, new Vector2(0, 0), Color.White);
            _spriteBatch.End();
            base.Draw(gameTime);
            counter2++;
        }

        public void DrawOnRenderTarget(RenderTarget2D target, List<FootprintObject> footprints)
        {
            GraphicsDevice.SetRenderTarget(target);
            GraphicsDevice.Clear(Color.Transparent);
            _spriteBatch.Begin();

            _spriteBatch.Draw(Assets.emptyScreen, Vector2.Zero, Color.White);
            foreach (FootprintObject footprint in footprints)
            {
                footprint.Draw(_spriteBatch);
            }
            _spriteBatch.End();
            GraphicsDevice.SetRenderTarget(null);
        }

        

        public bool OnBuildableArea(StructureBase s)
        {
            bool tempBool = false;
            int tempCounter1 = 0;
            int tempCounter2 = 0;
            Color[] pixels1 = new Color[s.StructFootprint.Width * s.StructFootprint.Height];
            Color[] pixels2 = new Color[s.StructFootprint.Width * s.StructFootprint.Height];
            s.StructFootprint.GetData<Color>(pixels2);
            //Crashed the program whenever I moved an item outside the rectangle so added this to just return false instead
            try { _buildableFootprints.GetData(0, s.HitBox, pixels1, 0, pixels1.Length); }
            catch { return false; }
            for (int i = 0; i < pixels1.Length; i++)
            {
                if (pixels1[i].A > 0.0f && pixels2[i].A > 0.0f)
                {
                    
                    tempCounter1++;
                    //return true;
                }
                else
                {
                    tempCounter2 += 3;
                    
                }
            }
            if(tempCounter1 >= tempCounter2) tempBool = true;
            return tempBool;
        }

        public bool NotObstructedByTurret(StructureBase s)
        {
            Color[] pixels1 = new Color[s.StructFootprint.Width * s.StructFootprint.Height];
            Color[] pixels2 = new Color[s.StructFootprint.Width * s.StructFootprint.Height];
            s.StructFootprint.GetData<Color>(pixels2);
            //Crashed the program whenever I moved an item outside the rectangle so added this to just return false instead
            try { _turretFootprints.GetData(0, s.HitBox, pixels1, 0, pixels1.Length); }
            catch { return false; }
            for (int i = 0; i < pixels1.Length; i++)
            {
                
                if (pixels1[i].A > 0.0f && pixels2[i].A > 0.0f)
                {
                    return false;
                }
            }
            return true;
        }

        public bool NotObstructedByStructure(StructureBase s)
        {
            Color[] pixels1 = new Color[s.StructFootprint.Width * s.StructFootprint.Height];
            Color[] pixels2 = new Color[s.StructFootprint.Width * s.StructFootprint.Height];
            s.StructFootprint.GetData<Color>(pixels2);
            //Crashed the program whenever I moved an item outside the rectangle so added this to just return false instead
            try { _structureFootprints.GetData(0, s.HitBox, pixels1, 0, pixels1.Length); }
            catch { return false; }
            for (int i = 0; i < pixels1.Length; i++)
            {
                if (pixels1[i].A > 0.0f && pixels2[i].A > 0.0f)
                {
                    return false;
                }
            }
            return true;
        }

        public static void QuitGame()
        {
            _thisGame.Exit();
        }

    }
}
