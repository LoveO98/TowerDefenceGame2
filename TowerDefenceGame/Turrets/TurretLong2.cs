using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TowerDefenceGame.Managers;
using TowerDefenceGame.StateMachines.LevelState;
using TowerDefenceGame.Structures;

namespace TowerDefenceGame.Turrets
{
    internal class TurretLong2 : TurretBase
    {
        public TurretLong2(Vector2 pos, LevelStateMachine levelContext) : base(Assets.turretLong2, pos, 80, 130, 800, 700, false, "Long Range Level 2", levelContext)
        {
            targetMode = TargetMode.mostHealth;
            _turretTopTex = Assets.turretBrightTopLong2;
            _turretGunTex = Assets.turretPointer2;
            _turretInfoForm.gbTurretHideUpg.Visible = true;
        }

        public override void PlacedOnStructure(StructureBase structure)
        {
            _placedOnStructure = structure;
            _range *= 1.2f;
            _piercing = true;
            _damage = 150;
        }

        public override void AttackParticles()
        {
            ParticleManager.CreateParticleTopDown(Assets.sparkTex, _structCentre, _target.Centre - _structCentre, 0, 1, 0, 0.5f, 50, 40, 10, 1, 1.8f, 1, 12345, 0, Color.Teal, new Color(Color.Blue, 20), new Color(Color.Black, 20));
            ParticleManager.CreateParticleTopDown(Assets.sparkCircleTex, _target.Centre, new Vector2(1, 0), 0, 0, 0, 0, 200, 150, 50, 0.8f, 1.2f, 1.3f, 0, 0, Color.Teal, new Color(Color.Red, 20), new Color(Color.Black, 20));
        }
    }
}
