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
        //this var is what text shows on screen when you finish a game
        public string gameResultText;

        //this will be used to communicate to drawingPanel who won or who lost or has a tie.
        public string result;

        public Controller()
        {
            r = new Random();
            CPUsChoice = choices[r.Next(choices.Length)];

        }

        public void randomizeCPUchoice()
        {
            r = new Random();
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
                        this.gameResultText = "Draw! You and your opponent both used Blastoise!";
                        this.result = "Draw!";
                    }

                    if (CPUsChoice == "Venusaur")
                    {
                        this.gameResultText = "You Lose! Your opponent's Venusaur beat your Blastoise!";
                        this.result = "You Lose!";
                    }

                    if (CPUsChoice == "Charizard")
                    {
                        this.gameResultText = "You Win! Your Blastoise beat your opponent's Charizard!";
                        this.result = "You Win!";

                    }
                    break;

                case "Venusaur":
                    if (CPUsChoice == "Venusaur")
                    {
                        this.gameResultText = "Draw! You and your opponent both used Venusaur!";
                        this.result = "Draw!";

                    }

                    if (CPUsChoice == "Blastoise")
                    {
                        this.gameResultText = "You Win! Your Venusaur beat your opponent's Blastoise!";
                        this.result = "You Win!";

                    }

                    if (CPUsChoice == "Charizard")
                    {
                        this.gameResultText = "You Lose! Your opponent's Charizard beat your Venusaur!";
                        this.result = "You Lose!";
                    }
                    break;

                case "Charizard":
                    if (CPUsChoice == "Charizard")
                    {
                        this.gameResultText = "Draw! You and your opponent both used Charizard!";
                        this.result = "Draw!";
                    }

                    if (CPUsChoice == "Blastoise")
                    {
                        this.gameResultText = "You Lose! Your opponent's Blastoise beat your Charizard!";
                        this.result = "You Lose!";
                    }

                    if (CPUsChoice == "Venusaur")
                    {
                        this.gameResultText = "You Win! Your Charizard beat your opponent's Venusaur!";
                        this.result = "You Win!";
                    }
                    break;
            }
        }

    }
}
