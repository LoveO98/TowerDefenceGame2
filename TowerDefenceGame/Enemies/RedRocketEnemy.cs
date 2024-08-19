using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TowerDefenceGame.Managers;
using TowerDefenceGame.Structures;
using TowerDefenceGame.Turrets;
using TowerDefenceGame.StateMachines.LevelState;

namespace TowerDefenceGame.Enemies
{
    internal class RedRocketEnemy : EnemyBase
    {

        public RedRocketEnemy(Vector2 pos, LevelStateMachine levelContext) : base(pos, Assets.redRocketEnemy, levelContext)
        {
            _speed = 40;
            _health = 70;
            _maxHealth = _health;
            _armour = 0;
            _scrapValue = 10;
            _alienScrapValue = 2;
            _detectRange = 600;
            _attackRange = 20;
            _attackDamage = 8;
            _attackCD = 500;
        }

        public override StructureBase FindTarget()
        {
            StructureBase tempTarget = _levelContext.City;
            float tempDistance;
            foreach (TurretBase turret in _levelContext.turrets)
            {
                tempDistance = Vector2.Distance(turret.StructCentre, _centre);
                if (tempDistance <= _detectRange && tempDistance <= Vector2.Distance(tempTarget.StructCentre, _centre))
                {
                    tempTarget = turret;
                }
            }
            return tempTarget;
        }
    }
}
