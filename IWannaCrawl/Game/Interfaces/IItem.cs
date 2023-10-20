using IWannaCrawl.Game.GameObjects.PlayerClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IWannaCrawl.Game.Interfaces
{
    internal interface IItem
    {
        public string? Name { get; }
        public int Id { get; }

        public void Take(Player player)
        {
        }
    }
}
