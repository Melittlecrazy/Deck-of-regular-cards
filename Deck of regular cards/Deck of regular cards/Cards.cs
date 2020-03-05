using System;
using static System.Console;
using static Deck_of_regular_cards.App;
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
        public string GetSuitAndValue()
        {
            switch (Suits)
            {
                case Suit.Clubs:
                    return $"{GetValue()}♣";
                case Suit.Spades:
                    return $"{GetValue()}♠";
                case Suit.Hearts:
                    return $"{GetValue()}♥";
                case Suit.Diamonds:
                    return $"{GetValue()}♦";
                default:
                    return GetValue();
            }
        }
        private string GetValue()
        {
            switch (Value)
            {
                case 1:
                    return "A";
                case 11:
                    return "J";
                case 12:
                    return "Q";
                case 13:
                    return "K";
                default:
                    return Convert.ToString(Value);
            }
        }
        public static void ShowCard(Cards card)
        {
            ConsoleColor color = ForegroundColor;
            if (card.Suits == Suit.Diamonds || card.Suits == Suit.Hearts)
            {
                ForegroundColor = ConsoleColor.DarkRed;
            }
            else
            {
                ForegroundColor = ConsoleColor.Black;
            }
            Print(CardImage(card));
            ForegroundColor = color;
        }
        public static void ShowCards(Cards cardA, Cards cardB) => Print(TwoCardImages(cardA, cardB));

        public static string CardImage(Cards card)
        {
            string value = card.GetSuitAndValue() + " ";
            if (card.Value != 10)
                value += " ";

            return $@"
         _____     
        |{value} |
        |     |
        |     |
        |     |
        |___{value}
            ";
        }

        public static string TwoCardImages(Cards cardA, Cards cardB)
        {//TODO: Change color depending on suit
            string valueA = cardA.Value != 10
                ? cardA.GetSuitAndValue() + " "
                : cardA.GetSuitAndValue();

            string valueB = cardB.Value != 10
                ? cardB.GetSuitAndValue() + " "
                : cardB.GetSuitAndValue();

            return $@"
           1             2
         _____         _____     
        |{valueA}  |       |{valueB}  |
        |     |       |     |
        |     |       |     |
        |     |       |     |
        |__{valueA}|       |__{valueB}|
";
        }
    }
}
