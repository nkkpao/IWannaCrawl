using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;

namespace IWannaCrawl.Game.GameObjects.Items.Weapons
{
    internal class Knife : Weapon
    {
        public Knife()
        {
            Damage = 1;
            Name = "Knife";
            Id = 1;
            Type = false;
        }
    }
}
