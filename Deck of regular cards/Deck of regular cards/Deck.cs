using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Deck_of_regular_cards.Utility;

namespace Deck_of_regular_cards
{
        internal enum Suit :byte
        {
            Clubs,
            Spades,
            Diamonds,
            Hearts
        } 
    internal class Deck
    {
        List<Cards> cards = new List<Cards>();
        public Suit[] Suits = { Suit.Clubs, Suit.Diamonds, Suit.Hearts, Suit.Spades };

        public int CardsInDeck => cards.Count;
        public int NumSuits => Suits.Length;

        //shuffle
        public void Shuffle()
        {
            Cards[] shuffled = cards.ToArray().OrderBy(x =>RanNum.Next()).ToArray();
            cards = shuffled.ToList();
        }

        //draw
        public Cards Draw()
        {
            return cards[RanNum.Next(cards.Count)];
        }

        //show
        public string Show(Cards card)
        {
            return card.Name;
        }

        //remove
        public void Remove(Cards card)
        {
            cards.Remove(card);
        }

        //constructer
        public Deck()
        {

        }

        //show all
        public string ShowAll()
        {
            return "";
        }
    }
}
