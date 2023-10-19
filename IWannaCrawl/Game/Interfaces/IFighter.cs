using IWannaCrawl.Game.GameEvents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IWannaCrawl.Game.Interfaces
{
    internal interface IFighter
    {
        int Level { get; set; }
        int MaxHp { get; set; }
        int CurrentHp { get; set; }

        //Status effects
        bool Bleeding { get; set; }
        bool Burning { get; set; }
        bool Freezed { get; set; }

        void Attack(IFighter target)
        {
        }


        bool Damage(int value)
        {
            CurrentHp = (CurrentHp - value) < 0 ? 0 : (CurrentHp - value);

            if (CurrentHp == 0)
            {
                return true;
            }
            return false;
        }

        void Heal(int value)
        {
            CurrentHp = (CurrentHp + value) > MaxHp ? MaxHp : (CurrentHp + value);
        }

    }
}
