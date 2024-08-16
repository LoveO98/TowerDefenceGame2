using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using TowerDefenceGame.Enemies;
using TowerDefenceGame.Managers;
using TowerDefenceGame.StateMachines.LevelState;
using TowerDefenceGame.Structures;

namespace TowerDefenceGame.Turrets
{
    internal class TurretFire : TurretBase
    {

        //These are the points 1/6th away from the turret and 2/3rds away from the turret. Used for calculating the hitbox of the attack.
        //I use these points instead of some rectangles with intersect because I want it to be as performance optimized as possible
        Vector2 _temp16Point;
        Vector2 _temp23Point;
        float _23Range;
        public TurretFire(Vector2 pos, LevelStateMachine levelContext) : base(Assets.turretFire, pos, 200, 4, 140, 120, false, "Flamethrower", levelContext)
        {
            targetMode = TargetMode.furthest;

            _23Range = _range / 3;
            _23Range *= 2;

            _turretTopTex = Assets.turretBrightTopFire;
            _turretGunTex = Assets.turretFireStick;
            _turretInfoForm.gbTurretHideUpg.Visible = true;
        }
        public override void PlacedOnStructure(StructureBase structure)
        {
            _placedOnStructure = structure;
            _range *= 1.2f;
            _damage = 5;
        }

        public override void Attack(GameTime gameTime)
        {
            if (_target != null)
            {
                SetDirection();
                if (!_isAttacking)
                {
                    _isAttacking = true;
                    AttackParticles();
                    _temp16Point = _targetDir * (_range / 6) + _structCentre;
                    _temp23Point = (_targetDir * _23Range) + _structCentre;
                    for (int i = 0; _levelContext.enemies.Count > i; i++)
                    {
                        //First checking if enemies are even close enough to the turret to be hit since an enemy which isn't getting hit would go through two "Vector2.Distance()" checks. I'm hoping most enemies on the map won't be in range
                        //of the average fire turret so this should be reducing the total amount of computations per frame.
                        if (Vector2.Distance(_levelContext.enemies[i].Centre, _structCentre) > _range) continue;
                        if (InHBArea(_levelContext.enemies[i], _temp16Point, _temp23Point))
                        {
                            bool kill;
                            float damage;
                            (damage, kill) = _levelContext.enemies[i].TakeDamage(_damage, _piercing);
                            _damageDealt += damage;
                            if (kill) _kills++;
                            //_damageDealt += _levelContext.enemies[i].TakeDamage(_damage, _onTower);
                        }
                    }
                }
            }


            _currentCD -= gameTime.ElapsedGameTime.Milliseconds;
            if (_currentCD <= 0)
            {
                _currentCD = _attackCD;
                _isAttacking = false;
            }
        }

        public bool InHBArea(EnemyBase enemy, Vector2 p1, Vector2 p2)
        {
            //Checking furthest point from the turret first since that's where enemies will enter and makes the tower not have to check the closer pos for most enemies. Hopefully at least
            float tempDistanceFar = Vector2.Distance(enemy.Centre, p2);
            if (tempDistanceFar < (_range / 3))
            {
                return true;
            }
            float tempDistanceNear = Vector2.Distance(enemy.Centre, p1);
            //Even if this point is 1/6th of the range away from the turret i search in an area of 1/3rd of the range here
            //This extra leeway is to avoid enemies right at the turret not getting hit
            if (tempDistanceNear < (_range / 3))
            {
                return true;
            }
            return false;
        }
        

        public override void AttackParticles()
        {
            ParticleManager.CreateParticleBottomUp(Assets.gasBallTex, _structCentre, Vector2.Normalize(_target.Centre - _structCentre), 0.3f, 3.2f, 0.2f, 1, 1000, 500, 500, 0.5f, 3, 2, 0, 0, new Color(Color.Blue * 0.1f, 20), new Color(Color.Red * 0.4f, 10), new Color(Color.Yellow * 0.6f, 20));
            ParticleManager.CreateParticleBottomUp(Assets.gasBallTex, _structCentre, Vector2.Normalize(_target.Centre - _structCentre), 0.3f, 3.2f, 0.2f, 1, 1000, 500, 500, 0.5f, 3, 2, 0, 0, new Color(Color.Blue * 0.1f, 20), new Color(Color.Red * 0.4f, 10), new Color(Color.Yellow * 0.6f, 20));
        }
    }
}
