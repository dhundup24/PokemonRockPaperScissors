using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinterBreak2021
{
    public partial class Form1 : Form
    {
       

        private DrawingPanel drawingPanel;

        //public delegate void CreateGUIButton(object sender, EventArgs e);


        private const int viewSize = 690;

        public Form1()
        {
            InitializeComponent();

            drawingPanel = new DrawingPanel();

            // Set the window size
            ClientSize = new Size(900, viewSize);
            drawingPanel.Location = new Point(0, 0);
            drawingPanel.Size = new Size(900, viewSize);
            this.Controls.Add(drawingPanel);


            this.Invalidate(true);


        }

        private void pokemonGameStartButton_Click(object sender, EventArgs e)
        {
            this.Controls.Remove(pokemonGameStartButton);
            this.Controls.Remove(HowToPlayButton);
            drawingPanel.isBackgroundDrawn = true;
            drawingPanel.isBattleScreenDrawn = false;
            drawingPanel.isHowToPlayScreenDrawn = true;
            this.Invalidate(true);

        }

        private void HowToPlayButton_Click(object sender, EventArgs e)
        {
            this.Controls.Remove(pokemonGameStartButton);
            this.Controls.Remove(HowToPlayButton);
            drawingPanel.isBackgroundDrawn = true;
            drawingPanel.isBattleScreenDrawn = true;
            drawingPanel.isHowToPlayScreenDrawn = false;
            this.Invalidate(true);

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
