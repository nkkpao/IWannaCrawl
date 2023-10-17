using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IWannaCrawl.Game.Helpers
{
    internal class RngProvider
    {
        public static Random Random { get; }

        static RngProvider()
        {
            Random = new Random();
        }
    }
}
