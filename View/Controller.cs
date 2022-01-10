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
            //string gameResult = "";
            this.playersChoice = playersChoice;

            switch (playersChoice)
            {
                case "Blastoise":
                    if(CPUsChoice == "Blastoise")
                    {
                        gameResult = "Draw! You and your opponent used the same Pokemon!";
                    }

                    if (CPUsChoice == "Venusaur")
                    {
                        gameResult = "You Lose! Your opponent used Venusaur!";
                    }

                    if (CPUsChoice == "Charizard")
                    {
                        gameResult = "You Win! Your opponent used Charizard!";
                    }
                    break;

                case "Venusaur":
                    if (CPUsChoice == "Venusaur")
                    {
                        gameResult = "Draw! You and your opponent used the same Pokemon!";
                    }

                    if (CPUsChoice == "Blastoise")
                    {
                        gameResult = "You Win! Your opponent used Blastoise!";
                    }

                    if (CPUsChoice == "Charizard")
                    {
                        gameResult = "You Lose! Your opponent used Charizard!";
                    }
                    break;

                case "Charizard":
                    if (CPUsChoice == "Charizard")
                    {
                        gameResult = "Draw! You and your opponent used the same Pokemon!";
                    }

                    if (CPUsChoice == "Blastoise")
                    {
                        gameResult = "You Lose! Your opponent used Blastoise!";
                    }

                    if (CPUsChoice == "Venusaur")
                    {
                        gameResult = "You Win! Your opponent used Venusaur!";
                    }
                    break;
            }
        }

    }
}
