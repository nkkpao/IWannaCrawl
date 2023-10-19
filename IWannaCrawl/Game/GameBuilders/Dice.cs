using IWannaCrawl.Game.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;


namespace IWannaCrawl.Game.GameEvents
{
    internal static class Dice
    {
        public static int D2(int count)
        {
            int trows = 0;
            for (int i = 0; i < count; i++) { trows += RngProvider.Random.Next(1, 3); }
            return trows;
        }

        public static int D4(int count)
        {
            int trows = 0;
            for (int i = 0; i < count; i++) { trows += RngProvider.Random.Next(1, 5); }
            return trows;
        }

        public static int D6(int count)
        {
            int trows = 0;
            for (int i = 0; i < count; i++) { trows += RngProvider.Random.Next(1, 7); }
            return trows;
        }

        public static int D8(int count)
        {
            int trows = 0;
            for (int i = 0; i < count; i++) { trows += RngProvider.Random.Next(1, 9); }
            return trows;
        }

        public static int D10(int count)
        {
            int trows = 0;
            for (int i = 0; i < count; i++) { trows += RngProvider.Random.Next(1, 11); }
            return trows;
        }

        public static int D12(int count)
        {
            int trows = 0;
            for (int i = 0; i < count; i++) { trows += RngProvider.Random.Next(1, 13); }
            return trows;
        }

        public static int D20(int count)
        {
            int trows = 0;
            for (int i = 0; i < count; i++) { trows += RngProvider.Random.Next(1, 21); }
            return trows;
        }
    }
}
