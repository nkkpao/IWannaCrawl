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

        InputReader reader = new InputReader();

        public BattleController(Player p)
        {
            player = p;
        }

        public void CreateBattle(List<Enemy> e)
        {
            enemies = e;
            Start();
        }

        protected void Start()
        {
            Console.WriteLine("Battle starts");
            for (int i = 1; i <= player.iCanDo.Count; i++)
            {
                Console.WriteLine();
            }
        }
    }
}
