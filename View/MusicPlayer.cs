using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace WinterBreak2021
{
    class MusicPlayer 
    {
        SoundPlayer openingMusic;
        SoundPlayer howToPlayMusic;
        SoundPlayer battleMusic;
        SoundPlayer youWinMusic;
        SoundPlayer youLoseMusic;
        private DrawingPanel drawingPanel;
        private Controller controller;
        public MusicPlayer(DrawingPanel drawingPanel, Controller controller)
        {
            this.drawingPanel = drawingPanel;
            this.controller = controller;
            //drawingPanel = new DrawingPanel();
            //All the music in the game
             openingMusic = new SoundPlayer(@"..\..\..\Resources\Music\pokemonRockPaperScissorsOpeningMusic.wav");
             howToPlayMusic = new SoundPlayer(@"..\..\..\Resources\Music\howToPlayMusic.wav");
             battleMusic = new SoundPlayer(@"..\..\..\Resources\Music\battleMusic.wav");
             youWinMusic = new SoundPlayer(@"..\..\..\Resources\Music\YouWinMusic.wav");
             youLoseMusic = new SoundPlayer(@"..\..\..\Resources\Music\YouLoseMusic.wav");
        }


        /// <summary>
        /// plays the specific song at the right time. No need for user input.
        /// </summary>
        public void playSong()
        {
            if (drawingPanel.drawThisBackground == "homeScreen")
            {
                openingMusic.Play();

            }

            else if (drawingPanel.drawThisBackground == "battleScreen")
            {
                battleMusic.Play();
            }
            else if (drawingPanel.drawThisBackground == "howToPlayScreen")
            {
                howToPlayMusic.Play();
            }
            else if (drawingPanel.drawThisBackground == "resultsScreen")
            {
                if (controller.result == "You Win!")
                {
                    youWinMusic.Play();

                }

                if (controller.result == "You Lose!" || controller.result == "Draw!")
                {
                    youLoseMusic.Play();
                }
            }



        }
    }
}
