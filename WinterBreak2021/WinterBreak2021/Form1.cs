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

            this.Shown += CreateButtonDelegate;

            this.Invalidate(true);


        }

        private void pokemonGameStartButton_Click(object sender, EventArgs e)
        {
            this.Controls.Remove(pokemonGameStartButton);
            this.Invalidate(true);

        }

        private void CreateButtonDelegate(object sender, EventArgs e)
        {
            Button newButton = new Button();
            this.Controls.Add(newButton);
            newButton.Text = "Created Button";
            newButton.Location = new Point(70, 70);
            newButton.Size = new Size(50, 100);
            newButton.Location = new Point(20, 50);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
