using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinterBreak2021
{
    class Controller
    {
        public string playersChoice;

        public string CPUsChoice;

        public string[] choices = { "Charizard", "Blastoise", "Venusaur" };

        public Random r;

        public string gameResult;

        public Controller()
        {
            r = new Random();
            CPUsChoice = choices[r.Next(choices.Length)];

        }

        public void determineWinner(string playersChoice)
        {
            this.playersChoice = playersChoice;

            switch (playersChoice)
            {
                case "Blastoise":
                    if(CPUsChoice == "Blastoise")
                    {
                        gameResult = "Draw! You and your opponent both used Blastoise!";
                    }

                    if (CPUsChoice == "Venusaur")
                    {
                        gameResult = "You Lose! Your opponent's Venusaur beat your Blastoise!";
                    }

                    if (CPUsChoice == "Charizard")
                    {
                        gameResult = "You Win! Your Blastoise beat your opponent's Charizard!";
                    }
                    break;

                case "Venusaur":
                    if (CPUsChoice == "Venusaur")
                    {
                        gameResult = "Draw! You and your opponent both used Venusaur!";
                    }

                    if (CPUsChoice == "Blastoise")
                    {
                        gameResult = "You Win! Your Venusaur beat your opponent's Blastoise!";
                    }

                    if (CPUsChoice == "Charizard")
                    {
                        gameResult = "You Lose! Your opponent's Charizard beat your Venusaur!";
                    }
                    break;

                case "Charizard":
                    if (CPUsChoice == "Charizard")
                    {
                        gameResult = "Draw! You and your opponent both used Charizard!";
                    }

                    if (CPUsChoice == "Blastoise")
                    {
                        gameResult = "You Lose! Your opponent's Blastoise beat your Charizard!";
                    }

                    if (CPUsChoice == "Venusaur")
                    {
                        gameResult = "You Win! Your Charizard beat your opponent's Venusaur!";
                    }
                    break;
            }
        }

    }
}
