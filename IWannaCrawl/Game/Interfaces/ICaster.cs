using IWannaCrawl.Game.GameObjects.Spells;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IWannaCrawl.Game.Interfaces
{
    internal interface ICaster
    {
        int MaxMp { get; set; }

        void Cast(Spell spell);
        
    }
}
