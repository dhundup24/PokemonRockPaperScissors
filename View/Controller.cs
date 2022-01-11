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

        public void randomizeCPUchoice()
        {
            CPUsChoice = choices[r.Next(choices.Length)];
        }

        /// <summary>
        /// updates the gameResult instance variable, so it can be used to be drawn on the screen later.
        /// </summary>
        /// <param name="playersChoice"></param>
        public void determineWinner(string playersChoice)
        {
            this.playersChoice = playersChoice;

            switch (playersChoice)
            {
                case "Blastoise":
                    if(CPUsChoice == "Blastoise")
                    {
                        this.gameResult = "Draw! You and your opponent both used Blastoise!";
                    }

                    if (CPUsChoice == "Venusaur")
                    {
                        this.gameResult = "You Lose! Your opponent's Venusaur beat your Blastoise!";
                    }

                    if (CPUsChoice == "Charizard")
                    {
                        this.gameResult = "You Win! Your Blastoise beat your opponent's Charizard!";
                    }
                    break;

                case "Venusaur":
                    if (CPUsChoice == "Venusaur")
                    {
                        this.gameResult = "Draw! You and your opponent both used Venusaur!";
                    }

                    if (CPUsChoice == "Blastoise")
                    {
                        this.gameResult = "You Win! Your Venusaur beat your opponent's Blastoise!";
                    }

                    if (CPUsChoice == "Charizard")
                    {
                        this.gameResult = "You Lose! Your opponent's Charizard beat your Venusaur!";
                    }
                    break;

                case "Charizard":
                    if (CPUsChoice == "Charizard")
                    {
                        this.gameResult = "Draw! You and your opponent both used Charizard!";
                    }

                    if (CPUsChoice == "Blastoise")
                    {
                        this.gameResult = "You Lose! Your opponent's Blastoise beat your Charizard!";
                    }

                    if (CPUsChoice == "Venusaur")
                    {
                        this.gameResult = "You Win! Your Charizard beat your opponent's Venusaur!";
                    }
                    break;
            }
        }

    }
}
