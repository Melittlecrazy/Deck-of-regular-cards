using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deck_of_regular_cards
{
    internal class App
    {
        Game game = new Game();

        public App()
        {
            Title = "Deck of Recular Cards";
            ForegroundColor = ConsoleColor.Blue;
            BackgroundColor = ConsoleColor.White;
            
            while (true)
                Menu();
        }

        protected void Run()
        {

        }

        protected void Menu()
        {
            Clear();
            //setup options for player
            WriteLine("Welcome, wanna play a game?");
            WriteLine("1) PlayHigher or Lower game (single player) \n2) Mystery game (Two player)\n3) Credits \n4) Exit");
            string input = ReadLine();
            switch (input)
            { //switches are a "incase the value is"

                case "1":
                    //HighLow();
                    break;
                case "2":

                    break;
                case "3":
                    WriteLine("Credited by Marc Gutierrez. Some code provided by programmingisfun.com");
                    ReadKey();
                    break;
                case "4":
                    WriteLine("Thank you for playing!! press any key to exit...");
                    ReadKey();
                    Environment.Exit(0);
                    break;
            }

        }
    }
}
