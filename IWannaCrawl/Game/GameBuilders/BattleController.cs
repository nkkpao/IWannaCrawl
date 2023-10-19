using IWannaCrawl.Game.GameObjects.PlayerClasses;
using IWannaCrawl.Game.GameObjects.Rooms.Enemies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IWannaCrawl.Game.GameBuilders
{
    internal class BattleController
    {
        Player player;

        List<Enemy> enemies = new List<Enemy>();

        public BattleController(Player p)
        {
            player = p;
        }
    }
}
