using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Media;

namespace TowerDefenceGame.Managers
{
    internal class Assets
    {
        //Particles
        public static Texture2D gasBallTex;
        public static Texture2D sparkTex;
        public static Texture2D sparkCircleTex;
        public static Texture2D debreeTex;
        public static Texture2D pixelCircle;
        public static Texture2D smoothCircle;

        //Things used for Render Target
        public static Texture2D square100x100;
        public static Texture2D square200x100;
        public static Texture2D square44in50;
        public static Texture2D square50x50;
        public static Texture2D emptyScreen;
        public static Texture2D fireHB1;
        public static Texture2D fireHB2;

        //Non-Turret infrastructure / background
        public static Texture2D background1;
        public static Texture2D genericLevelBackground;
        public static Texture2D menuBackground;
        public static Texture2D cityBase;
        public static Texture2D structureTower;
        public static Texture2D enemySpawn;

        //TurretParts
        public static Texture2D cogIn50;
        public static Texture2D turretBrightTop;
        public static Texture2D turretBrightTopFire;
        public static Texture2D turretBrightTopLong2;
        public static Texture2D turretBrightTopMedium2;
        public static Texture2D turretBrightTopPierce;
        public static Texture2D turretBrightTopShort2;
        public static Texture2D turretBrightTopZap;
        public static Texture2D turretCannon;
        public static Texture2D turretCannon2;
        public static Texture2D turretDarkCircleBase;
        public static Texture2D turretGoldAntenna;
        public static Texture2D turretPointer;
        public static Texture2D turretPointer2;
        public static Texture2D turretRedPipe;
        public static Texture2D turretRedPipe2;
        public static Texture2D turretFireStick;
        public static Texture2D turretPierceBarrel;

        //Full turretSprites
        public static Texture2D turretFire;
        public static Texture2D turretLong;
        public static Texture2D turretLong2;
        public static Texture2D turretMedium;
        public static Texture2D turretMedium2;
        public static Texture2D turretPierce;
        public static Texture2D turretShort;
        public static Texture2D turretShort2;
        public static Texture2D turretZap;

        //Enemies
        public static Texture2D basicEnemy;
        public static Texture2D heavyEnemy;
        public static Texture2D redRocketEnemy;
        public static Texture2D tankEnemy;
        public static Texture2D walkingFortressEnemy;

        //Miscelaneous textures
        public static Texture2D turretSelectOutline;
        public static Texture2D towerSelectOutline;
        public static Texture2D spawnerSelectOutline;
        public static Texture2D noNoZoneUI;

        //Music
        public static Song menuMusic;
        public static Song luftrauser;
        public static Song hellrauser;
        public static Song luftrauserDamaged;

        //Sound effects
        public static SoundEffect placeStructureThump;

        //Font
        public static SpriteFont font;

        public static void LoadTextures(ContentManager Content)
        {
            gasBallTex = Content.Load<Texture2D>(@"GasBall");
            sparkTex = Content.Load<Texture2D>(@"Spark");
            sparkCircleTex = Content.Load<Texture2D>(@"CircleSpark");
            debreeTex = Content.Load<Texture2D>(@"Debree");
            pixelCircle = Content.Load<Texture2D>(@"PixelCircle");
            smoothCircle = Content.Load<Texture2D>(@"SmoothCircle");

            square100x100 = Content.Load<Texture2D>(@"100x100Square");
            square200x100 = Content.Load<Texture2D>(@"200x100Square");
            square44in50 = Content.Load<Texture2D>(@"44in50Square");
            square50x50 = Content.Load<Texture2D>(@"50x50Square");
            emptyScreen = Content.Load<Texture2D>(@"EmptyScreen");
            fireHB1 = Content.Load<Texture2D>(@"FireHB1");
            fireHB2 = Content.Load<Texture2D>(@"FireHB2");

            background1 = Content.Load<Texture2D>(@"Background1");
            genericLevelBackground = Content.Load<Texture2D>(@"GenericLevelBackground");
            menuBackground = Content.Load<Texture2D>(@"MenuBackground");
            cityBase = Content.Load<Texture2D>(@"CityBase");
            structureTower = Content.Load<Texture2D>(@"StructureTower");
            enemySpawn = Content.Load<Texture2D>(@"EnemySpawn");

            cogIn50 = Content.Load<Texture2D>(@"CogIn50");
            turretBrightTop = Content.Load<Texture2D>(@"TowerBrightTop");
            turretBrightTopFire = Content.Load<Texture2D>(@"TowerBrightTopFire");
            turretBrightTopLong2 = Content.Load<Texture2D>(@"TowerBrightTopLong2");
            turretBrightTopMedium2 = Content.Load<Texture2D>(@"TowerBrightTopMedium2");
            turretBrightTopPierce = Content.Load<Texture2D>(@"TowerBrightTopPierce");
            turretBrightTopShort2 = Content.Load<Texture2D>(@"TowerBrightTopShort2");
            turretBrightTopZap = Content.Load<Texture2D>(@"TowerBrightTopZap");
            turretCannon = Content.Load<Texture2D>(@"TowerCannon");
            turretCannon2 = Content.Load<Texture2D>(@"TowerCannon2");
            turretDarkCircleBase = Content.Load<Texture2D>(@"TowerDarkCircleBase");
            turretGoldAntenna = Content.Load<Texture2D>(@"TowerGoldAntenna");
            turretPointer = Content.Load<Texture2D>(@"TowerPointer");
            turretPointer2 = Content.Load<Texture2D>(@"TowerPointer2");
            turretRedPipe = Content.Load<Texture2D>(@"TowerRedPipe");
            turretRedPipe2 = Content.Load<Texture2D>(@"TowerRedPipe2");
            turretFireStick = Content.Load<Texture2D>(@"TowerFireStick");
            turretPierceBarrel = Content.Load<Texture2D>(@"TowerPierceBarrel");

            turretFire = Content.Load<Texture2D>(@"TowerFire");
            turretLong = Content.Load<Texture2D>(@"TowerLong");
            turretLong2 = Content.Load<Texture2D>(@"TowerLong2");
            turretMedium = Content.Load<Texture2D>(@"TowerMedium");
            turretMedium2 = Content.Load<Texture2D>(@"TowerMedium2");
            turretPierce = Content.Load<Texture2D>(@"TowerPierce");
            turretShort = Content.Load<Texture2D>(@"TowerShort");
            turretShort2 = Content.Load<Texture2D>(@"TowerShort2");
            turretZap = Content.Load<Texture2D>(@"TowerZap");

            basicEnemy = Content.Load<Texture2D>(@"BasicEnemy");
            heavyEnemy = Content.Load<Texture2D>(@"HeavyEnemy");
            redRocketEnemy = Content.Load<Texture2D>(@"RedRocketEnemy");
            tankEnemy = Content.Load<Texture2D>(@"TankEnemy");
            walkingFortressEnemy = Content.Load<Texture2D>(@"WalkingFortressEnemy");

            turretSelectOutline = Content.Load<Texture2D>(@"TurretSelectOutline");
            towerSelectOutline = Content.Load<Texture2D>(@"TowerSelectOutline");
            spawnerSelectOutline = Content.Load<Texture2D>(@"SpawnerSelectOutline");
            noNoZoneUI = Content.Load<Texture2D>(@"NoNoZoneUI");

            menuMusic = Content.Load<Song>(@"MenuMusicTD");
            luftrauser = Content.Load<Song>(@"Luftrauser");
            hellrauser = Content.Load<Song>(@"Hellrauser");
            luftrauserDamaged = Content.Load<Song>(@"LuftrauserDamaged");

            placeStructureThump = Content.Load<SoundEffect>(@"PlaceStructureThump");

            font = Content.Load<SpriteFont>(@"File");
        }
    }
}
