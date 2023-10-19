using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IWannaCrawl.Game.GameObjects.Items.Weapons
{
    internal class IronSword : Weapon
    {
        public IronSword()
        {
            Damage = 4;
            Name = "IronSword";
            Id = 1;
            Type = false;
        }
    }
}
