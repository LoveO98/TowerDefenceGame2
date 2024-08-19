using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using TowerDefenceGame.Managers;
using TowerDefenceGame.StateMachines.LevelState;
using TowerDefenceGame.Structures;

namespace TowerDefenceGame.Turrets
{
    internal class TurretPierce : TurretBase
    {

        public TurretPierce(Vector2 pos, LevelStateMachine levelContext) : base(Assets.turretPierce, pos, 50, 130, 600, 650, true, "High caliber", levelContext)
        {
            targetMode = TargetMode.mostTotHealth;
            _turretTopTex = Assets.turretBrightTopPierce;
            _turretGunTex = Assets.turretPierceBarrel;
            _turretInfoForm.gbTurretHideUpg.Visible = true;
        }

        public override void PlacedOnStructure(StructureBase structure)
        {
            _placedOnStructure = structure;
            _range *= 1.2f;
            _damage = 170;
        }

        public override void AttackParticles()
        {
            ParticleManager.CreateParticleTopDown(Assets.sparkCircleTex, _target.Centre, new Vector2(1, 0), 0, 0, 0, 0, 200, 150, 50, 0.8f, 1.2f, 1.3f, 0, 0, Color.Teal, new Color(Color.Purple, 200), new Color(Color.Black, 20));
        }

    }
}
