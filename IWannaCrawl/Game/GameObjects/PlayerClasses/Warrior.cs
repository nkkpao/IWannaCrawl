using IWannaCrawl.Game.GameEvents;
using IWannaCrawl.Game.GameObjects.Items.Weapons;
using IWannaCrawl.Game.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IWannaCrawl.Game.GameObjects.PlayerClasses
{
    internal class Warrior : Player, IFighter
    {
        public Warrior(int level = 1)
        {
            Level = level;
            MaxHp = Level * 8 + Level;
            CurrentHp = MaxHp;
            Bleeding = false;
            Burning = false;
            Freezed = false;
            Weapon = new IronSword();
            ICanDo.Add("Attack");
            ICanDo.Add("Run");
            ICanDo.Add("Use item");
        }

        public override void Attack(IFighter target)
        {
            target.Damage(Dice.D6(Level) + Weapon.Damage);
        }

    }
}
