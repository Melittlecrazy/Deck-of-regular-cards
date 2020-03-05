using System;
using static System.Console;
using static Deck_of_regular_cards.App;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deck_of_regular_cards
{
    internal class Game
    {
        public Deck Deck = new Deck(52, new Suit[] { Suit.Clubs, Suit.Spades, Suit.Diamonds, Suit.Hearts });
        protected bool AceHigh = true;
        protected List<Player> Players = new List<Player>();
        protected int totalPlayers = 1;
        protected string title = "War";
        protected string instructions = "";

        protected string ShowScores()
        {
            string output = "";
            foreach (Player p in Players)
            {
                output += $"{p.Name}'s score: {p.Score}\t";
            }
            return output;
        }
        protected string ShowWinner()
        {
            if (Players.Count == 2)
            {
                if (Players[0].Score != Players[1].Score)
                {
                    if (Players[0].Score > Players[1].Score)
                    {
                        return $"{Players[0].Name} won!";
                    }
                    else
                    {
                        return $"{Players[1].Name} won!";
                    }
                }
                else
                {
                    return "The game is tied - both players win!";
                }
            }
            return "";
        }
        protected void GetPlayers()
        {
            if (totalPlayers > 1)
            {
                for (int i = 0; i < totalPlayers; i++)
                {
                    bool notSet = true;
                    while (notSet)
                    {
                        string input = GetInput($"Player {i + 1} name: ");
                        if (Confirmation(input))
                        {
                            Players.Add(new Player(input));
                            notSet = false;
                        }
                    }
                    if (Players[i].Name == "Player" || Players[i].Name == " " || Players[i].Name == "")
                    {
                        Players[i].Name = $"Player {i + 1}";
                    }
                }
            }
            else
            {
                Players.Add(new Player("Player"));
            }
        }
        protected void ShowInstructions(string instructions)
        {
            Print($"\n\nInstructions:\n\n{instructions}\n");
            Pause();
        }
        protected void ShowTitle(string title) => Print(title);
        protected void ShowScore(string score) => Print(score);
        protected void ShowSummary(string summary)
        {
            Clear();
            Print(summary);
            Pause();
        }
    }
}
