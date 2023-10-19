using IWannaCrawl.Game.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IWannaCrawl.Game.GameObjects.Items.Weapons
{
    internal class Weapon : IItem
    {
        public string? Name { get; set; }
        public int Id { get; set; }
        public int Damage { get; set; }
        public bool Type { get; set; } //0 is meele, 1 is ranged
    }
}
