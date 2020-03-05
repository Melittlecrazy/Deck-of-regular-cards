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
        War war = new War();

        public App()
        {
            Title = "Deck of Recular Cards";
            ForegroundColor = ConsoleColor.Blue;
            BackgroundColor = ConsoleColor.White;
            
            while (true)
                Menu();
        }

        protected void Menu()
        {
            Clear();
            //setup options for player
            WriteLine("Welcome, wanna play a game?");
            WriteLine("1) PlayHigher or Lower game (single player) \n2) War (single/multiplayer)\n3) Credits \n4) Exit");
            string input = ReadLine();
            switch (input)
            { //switches are a "incase the value is"

                case "1":
                    //HighLow();
                    break;
                case "2":
                    war.Play();
                    ReadKey();
                    break;
                case "3":
                    WriteLine("Credited by Marc Gutierrez & Gabe Salas. Some code provided by programmingisfun.com");
                    ReadKey();
                    break;
                case "4":
                    WriteLine("Thank you for playing!! press any key to exit...");
                    ReadKey();
                    Environment.Exit(0);
                    break;
            }

        }
        static public void Print(string _message) => WriteLine(_message);
        static public void Pause()
        {
            Print("Press any key to continue...");
            ReadKey();
        }
        public static string GetInput(string message)
        {
            Print(message);
            return ReadLine();
        }
        public static ConsoleKey KeyPressed
        {
            get
            {
                ConsoleKey keyPressed = Console.ReadKey().Key;
                return keyPressed;
            }
        }
        public static bool Confirmation(string input)
        {
            Print($"You entered {input}.\nPress x to change what you've entered.\nPress any key besides x to continue.");
            string answer = ReadLine();
            if (answer.ToLower() == "x")
            { return false; }
            return true;
        }
    }
}
