using IWannaCrawl.Game.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IWannaCrawl.Game.GameObjects.Rooms.Enemies
{
    internal abstract class Enemy : IFighter, IMortal
    {
        public int Level { get; set; }
        public int CurrentHp { get; set; }
        public int MaxHp { get; set; }


    }
}
