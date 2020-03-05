using System;
using static System.Console;
using static Deck_of_regular_cards.App;
using static Deck_of_regular_cards.Game;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deck_of_regular_cards
{
    class HighLow : Game
    {
        public HighLow()
        {
            SetUp();
            Play();
        }
        private void SetUp()
        {
            Clear();
            Title = "High-Low";
            instructions = "I'll draw the top card and tell you what it is.\nYou'll guess whether the next card will be higher, or lower. If you guess correctly, you'll get a point.";
            AceHigh = true;
            Deck = new Deck(52, new Suit[] { Suit.Clubs, Suit.Spades, Suit.Diamonds, Suit.Hearts });
            title = @"
  _    _ _       _                _                   
 | |  | (_)     | |              | |                  
 | |__| |_  __ _| |__    ______  | |     _____      __
 |  __  | |/ _` | '_ \  |______| | |    / _ \ \ /\ / /
 | |  | | | (_| | | | |          | |___| (_) \ V  V / 
 |_|  |_|_|\__, |_| |_|          |______\___/ \_/\_/  
            __/ |                                     
           |___/                                      
";

            ShowTitle(title);
            ShowInstructions(instructions);
            GetPlayers();
            Deck.Shuffle();
        }
        private void Play()
        {
            ConsoleKey theKey;
            Cards current;
            Cards next;
            string output;
            while (Deck.CardsInDeck > 1)
            {
                string score = (AceHigh) ? "High-Low (Aces high)" : "High-Low (Aces low)";
                score += "\n----------------------------------------\n";
                output = (Deck.CardsInDeck <= 2) ? "LAST ROUND" : $"cards left: {Deck.CardsInDeck}";
                score += $"Score: {Players[0].Score}, {output}";
                score += "\n----------------------------------------";
                Clear();
                ShowScore(score);
                current = Deck.DrawNext();
                PrintInline($"I've turned over the top card on the deck. It is {current.Name}.");
                ShowCard(current);
                Deck.Remove(current);
                Print("Will the next card drawn be 1) higher or 2) lower?");
                theKey = KeyPressed;
                next = Deck.DrawNext();
                PrintInline($"\nThe next card is {next.Name}.");
                ShowCard(next);

                if (current.Value == next.Value)
                    Print("Card values are same, no win", "alert");
                else
                    CheckDecision(theKey, current, next);

                Pause();
            }
            string summary = $"GAME FINISHED!\nYour final score is: {Players[0].Score}";
            ShowSummary(summary);
        }
        private void CheckDecision(ConsoleKey theKey, Cards current, Cards next)
        {
            if (theKey == ConsoleKey.D1)
                CheckDecisionHigher(current, next);
            else
                CheckDecisionLower(current, next);
        }


        //TODO: Simplify CheckDecisionHigher and CheckDecisionLower
        private void CheckDecisionHigher(Cards current, Cards next)
        {
            if ((current.Value != 1) && ((next.Value > current.Value) || (next.Value == 1)))
            {
                Print($"You were right! {next.Name} is higher than {current.Name}", "correct");
                Players[0].ChangeScore(1);
            }
            else
                Print($"Sorry, {next.Name} is lower than {current.Name}", "incorrect");
        }
        private void CheckDecisionLower(Cards current, Cards next)
        {
            if ((next.Value != 1) && ((next.Value < current.Value) || (current.Value == 1)))
            {
                Print($"You were right! {next.Name} is lower than {current.Name}", "correct");
                Players[0].ChangeScore(1);
            }
            else
                Print($"Sorry, {next.Name} is higher than {current.Name}", "incorrect");
        }

    }
}
