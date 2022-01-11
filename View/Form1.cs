using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;

namespace WinterBreak2021
{
    public partial class Form1 : Form
    {
        public SoundPlayer music;
        


        private DrawingPanel drawingPanel;
        private const int viewSize = 690;

        public Form1()
        {
            InitializeComponent();

            drawingPanel = new DrawingPanel();

            //music = new SoundPlayer(@"..\..\..\Resources\Music\pokemonRockPaperScissorsOpeningMusic.wav");           
            //music.Play();

            
            // Set the window size
            ClientSize = new Size(900, viewSize);
            drawingPanel.Location = new Point(0, 0);
            drawingPanel.Size = new Size(900, viewSize);
            this.Controls.Add(drawingPanel);
            drawingPanel.drawThisBackground = "homeScreen";


            this.Invalidate(true);

        }

        private void pokemonGameStartButton_Click(object sender, EventArgs e)
        {
            this.Controls.Remove(drawingPanel.startButton);
            this.Controls.Remove(drawingPanel.HowToPlayButton);
            drawingPanel.drawThisBackground = "battleScreen";
            this.Invalidate(true);

        }

        private void HowToPlayButton_Click(object sender, EventArgs e)
        {
            this.Controls.Remove(drawingPanel.startButton);
            this.Controls.Remove(drawingPanel.HowToPlayButton);
            drawingPanel.drawThisBackground = "howToPlayScreen";
            this.Invalidate(true);

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
