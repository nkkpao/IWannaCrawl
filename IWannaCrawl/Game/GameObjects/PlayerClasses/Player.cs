using IWannaCrawl.Game.GameEvents;
using IWannaCrawl.Game.GameObjects.Items.Weapons;
using IWannaCrawl.Game.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IWannaCrawl.Game.GameObjects.PlayerClasses
{
    internal abstract class Player : IFighter
    {
        public List<string> iCanDo;
        public int Level { get; set; }
        public int CurrentHp { get; set; }
        public int MaxHp { get; set; }
        public bool Bleeding { get; set; }
        public bool Burning { get; set; }
        public bool Freezed { get; set; }
        public Weapon Weapon { get; set; } = new Knife();

        public virtual void Attack(IFighter target)
        {

        }

        public void WhatICanDo()
        {
            if (iCanDo == null)
            {
                throw new Exception("iCanDo not initializated");
            }
            
            for(int i = 1; i <= iCanDo.Count; i++)
            {
                Console.WriteLine($"{i}. {iCanDo[i - 1]}");
            }
        }

    }
}
