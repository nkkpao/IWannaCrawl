using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IWannaCrawl.Game.Interfaces
{
    internal interface IMortal
    {
        int MaxHp { get; set; }
        int CurrentHp { get; set; }

        bool Damage(int value)
        {
            CurrentHp = (CurrentHp - value) < 0 ? 0 : (CurrentHp - value);

            if(CurrentHp == 0)
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
