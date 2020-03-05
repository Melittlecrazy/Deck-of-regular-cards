using System;
using static System.Console;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deck_of_regular_cards
{
    class Player
    {
        public string Name;
        public int Score = 0;
        public List<Cards> Hand = new List<Cards>();
        private readonly TextInfo info = new CultureInfo("en-US", false).TextInfo;

        public void ChangeScore(int amount) => Score += amount;
        public Player(string name) => Name = SetName(name);
        public string SetName(string name)
        {
            if (name != "")
            {
                if (name.Length <= 20)
                {
                    return info.ToTitleCase(name);
                }
                else
                {
                    return info.ToTitleCase(name.Substring(0, 20));
                }
            }
            return "Player";
        }
    }
}
