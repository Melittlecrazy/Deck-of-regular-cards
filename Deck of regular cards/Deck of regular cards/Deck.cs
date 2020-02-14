using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deck_of_regular_cards
{
    class Deck
    {
        public static void Run()
        {
            for (int i = 0; i < 13; i++)
            {
                WriteLine(ConsoleColor.Red + Cards.hearts[].Length);
                WriteLine(ConsoleColor.Red + Cards.dimonds[].Length);
                WriteLine(Cards.spades[].Length);
                WriteLine(Cards.clubs[].Length);
            }
        }
    }
}
