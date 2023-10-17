using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IWannaCrawl.Game.GameObjects.Spells
{
    internal abstract class Spell
    {
        protected int ManaCost { get; set; }
        public virtual void Cast() {  }
    }
}
