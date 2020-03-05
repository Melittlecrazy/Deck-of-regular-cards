using System;
using static System.Console;
using static Deck_of_regular_cards.Game;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deck_of_regular_cards
{
    class War : Game
    {
        int Card;
        int Second;

        Deck deck = new Deck();
        public void Play()
        {
            title = "War";
            instructions = "";
            Title = title;
            AceHigh = true;
            Deck = new Deck(52, new Suit[] { Suit.Clubs, Suit.Spades, Suit.Diamonds, Suit.Hearts });

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
