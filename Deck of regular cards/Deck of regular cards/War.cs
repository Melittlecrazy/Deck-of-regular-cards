using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deck_of_regular_cards
{
    class War
    {
        int Card;
        int Second;

        Deck deck = new Deck();
        public void Play()
        {
            Clear();
            WriteLine("I see you want to play some War.");
            Setup();

        }

        void Setup()
        {
            //deck.Shuffle();
            
            for(int i =0; i <= deck.cards.Count; i++)
            {
                WriteLine(deck.cards[i]);
            }
        }

        void GoToWar()
        {
            

        }

        public void CheckCard()
        {
            if (Card == Second)
            {
                GoToWar();
            }
            else if (Card > Second)
            {

            }
            else 
            {

            }
        }
    }
}
