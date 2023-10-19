using IWannaCrawl.Game.GameEvents;
using IWannaCrawl.Game.GameObjects.Items.Weapons;
using IWannaCrawl.Game.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IWannaCrawl.Game.GameObjects.PlayerClasses
{
    internal abstract class Player : IFighter
    {
        protected List<string>? ICanDo;
        public int Level { get; set; }
        public int CurrentHp { get; set; }
        public int MaxHp { get; set; }
        public bool Bleeding { get; set; }
        public bool Burning { get; set; }
        public bool Freezed { get; set; }
        public Weapon Weapon { get; set; }

        public virtual void Attack(IFighter target)
        {

        }
    }
}
