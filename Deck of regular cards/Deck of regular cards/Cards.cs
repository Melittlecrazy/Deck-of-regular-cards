using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deck_of_regular_cards
{
    class Cards
    {
        public string Name;
        public int Value;
        public Suit Suits;

        public Cards(string _name, Suit _suits, int _value)
        {
            Name = _name;
            Suits = _suits;
            Value = _value;
        }
    }
}
