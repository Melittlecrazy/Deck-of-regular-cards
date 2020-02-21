using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deck_of_regular_cards
{
    class Game
    {
        public List<Player> Players = new List<Player>();
        public Deck deck = new Deck();


        public void HighLow()
        {
            Clear();


            deck = new Deck();

        }
    }
}
