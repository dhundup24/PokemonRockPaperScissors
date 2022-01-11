using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace WinterBreak2021
{
    public class DrawingPanel : Panel
    {
        public string drawThisBackground;
        private Controller c; 


        //These below are for the opening screen
        Image background = Image.FromFile(@"..\..\..\Resources\Images\pokemonGameBackground.png");
        Image battleScreen = Image.FromFile(@"..\..\..\Resources\Images\pokemonGameBattleScreen.png");
        Image gameLogo1 = Image.FromFile(@"..\..\..\Resources\Images\pokemonGameLogo.png");
        Image howToPlayButton = Image.FromFile(@"..\..\..\Resources\Images\HowToPlayButton.png");
        Image startButtonImage = Image.FromFile(@"..\..\..\Resources\Images\pokemonGameStartButton.png");
        Image howToPlayImage = Image.FromFile(@"..\..\..\Resources\Images\HowToPlayButton.png");


        //These below are for the battle screen
        Image charizard = Image.FromFile(@"..\..\..\Resources\Images\Charizard.png");
        Image venusaur = Image.FromFile(@"..\..\..\Resources\Images\venusaur.png");
        Image blastoise = Image.FromFile(@"..\..\..\Resources\Images\blastoise.png");
        Image homeButtonImage = Image.FromFile(@"..\..\..\Resources\Images\homeButton.png");

        Image resultsScreenBackground = Image.FromFile(@"..\..\..\Resources\Images\resultsScreen.png");


        public Button charizardButton = new Button();
        public Button venusaurButton = new Button();
        public Button blastoiseButton = new Button();
        public Button homeButton = new Button();
        public Button startButton = new Button();
        public Button HowToPlayButton = new Button();




        Image gameLogo2 = Image.FromFile(@"..\..\..\Resources\Images\PokemonRockPaperScissorsLogo.png");
        Image howToPlayBackground = Image.FromFile(@"..\..\..\Resources\Images\HowToPlayBackground.png");

        public DrawingPanel()
        {
            this.DoubleBuffered = true;
            
            charizard = resizeImage(charizard, new Size(300, 280));
            venusaur = resizeImage(venusaur, new Size(300, 280));
            blastoise = resizeImage(blastoise, new Size(300, 280));
            homeButtonImage = resizeImage(homeButtonImage, new Size(100, 100));
            startButtonImage = resizeImage(startButtonImage, new Size(300, 75));

            charizardButton = CreateGUIButton(charizard, 0, 200, new Size(270, 270), CharizardButton_Click);
            venusaurButton = CreateGUIButton(venusaur, 300, 200, new Size(270, 270), VenusaurButton_Click);
            blastoiseButton = CreateGUIButton(blastoise, 600, 200, new Size(270, 270), BlastoiseButton_Click);
            homeButton = CreateGUIButton(homeButtonImage, 0, 620, new Size(70, 70), homeButton_Click);
            startButton = CreateGUIButton(startButtonImage, 341, 462, new Size(219, 82), startButton_Click);
            HowToPlayButton = CreateGUIButton(howToPlayImage, 732, 611, new Size(166, 78), howToPlayButton_Click);
        }

        private void howToPlayButton_Click(object sender, EventArgs e)
        {
            drawThisBackground = "howToPlayScreen";
            this.Invalidate(true);
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            drawThisBackground = "battleScreen";
            this.Invalidate(true);
        }

        private void BlastoiseButton_Click(object sender, EventArgs e)
        {
            this.drawThisBackground = "resultsScreen";
            c = new Controller();
            c.determineWinner("Blastoise");
            this.Controls.Remove(blastoiseButton);
            this.Controls.Remove(charizardButton);
            this.Controls.Remove(venusaurButton);

            this.Invalidate(true);

        }



        private void VenusaurButton_Click(object sender, EventArgs e)
        {
            this.drawThisBackground = "resultsScreen";
            c = new Controller();
            c.determineWinner("Venusaur");
            this.Controls.Remove(blastoiseButton);
            this.Controls.Remove(charizardButton);
            this.Controls.Remove(venusaurButton);

            this.Invalidate(true);


        }

        private void CharizardButton_Click(object sender, EventArgs e)
        {
            this.drawThisBackground = "resultsScreen";
            c = new Controller();
            c.determineWinner("Charizard");
            this.Controls.Remove(blastoiseButton);
            this.Controls.Remove(charizardButton);
            this.Controls.Remove(venusaurButton);

            this.Invalidate(true);


        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            this.drawThisBackground = "homeScreen";
            this.Controls.Remove(homeButton);
            this.Controls.Remove(blastoiseButton);
            this.Controls.Remove(charizardButton);
            this.Controls.Remove(venusaurButton);

            this.Invalidate(true);
        }



        public void drawHomeBackground(object o, PaintEventArgs e, SoundPlayer song)
        {
            song.Play();
            int width = 900;
            int height = 690;
            e.Graphics.DrawImage(background, 0, 0, width, height);
            e.Graphics.DrawImage(gameLogo1, 240, 150, 400, 170);

            //System.Threading.Thread.Sleep(800);
            
            e.Graphics.DrawImage(gameLogo2, 110, 300, 680, 160);

            this.Controls.Add(startButton);
            this.Controls.Add(HowToPlayButton);

        }

        public void drawBattleScreen(object o,  PaintEventArgs e, SoundPlayer song)
        {
            song.Play();


            int width = 900;
            int height = 690;
            e.Graphics.DrawImage(battleScreen, 0, 0, width, height);


            this.Controls.Add(homeButton);
            this.Controls.Add(charizardButton);
            this.Controls.Add(blastoiseButton);
            this.Controls.Add(venusaurButton);

            this.Controls.Remove(startButton);
            this.Controls.Remove(HowToPlayButton);


            drawCommandPrompt(e);
        }

        public void drawResultsScreen( PaintEventArgs e, SoundPlayer song, SoundPlayer song2)
        {
            if(c.gameResult.Substring(0,8) == "You Lose!" || c.gameResult.Substring(0, 5) == "Draw!")
            {
            song.Play();

            }

            if (c.gameResult.Substring(0, 7) == "You Win!")
            {
                song2.Play();

            }

            int width = 1050;
            int height = 700;
            e.Graphics.DrawImage(resultsScreenBackground, 0, 0, width, height);

        }

        public void drawHowToPlayScreen(object o, PaintEventArgs e, SoundPlayer song)
        {
            song.Play();

            int width = 900;
            int height = 690;
            e.Graphics.DrawImage(howToPlayBackground, 0, 0, width, height);

            homeButtonImage = resizeImage(homeButtonImage, new Size(100, 100));
            this.Controls.Remove(startButton);
            this.Controls.Remove(HowToPlayButton);
            this.Controls.Add(homeButton);

            drawInstructions(e);
        }

        public Button CreateGUIButton(Image i, int x, int y, Size size, EventHandler c)
        {

            Button newButton = new Button();
            newButton.Click += c;


            newButton.Image = i;
            newButton.Size = size;
            newButton.Location = new Point(x, y);
            return newButton;
        }


        public static Image resizeImage(Image imgToResize, Size size)
        {
            return (Image)(new Bitmap(imgToResize, size));
        }



        /// <summary>
        /// onPaint tells the drawingPanel which background to draw
        /// </summary>
        /// <param name="e"></param>
        protected override void OnPaint(PaintEventArgs e)
        {
            if (drawThisBackground == "homeScreen")
            {
                drawHomeBackground(background, e, new SoundPlayer(@"..\..\..\Resources\Music\pokemonRockPaperScissorsOpeningMusic.wav"));
            }

            else if (drawThisBackground == "battleScreen")
            {               
                drawBattleScreen(battleScreen, e, new SoundPlayer(@"..\..\..\Resources\Music\YouWinMusic.wav"));
            }

            else if (drawThisBackground == "howToPlayScreen")
            {
                drawHowToPlayScreen(howToPlayBackground, e, new SoundPlayer(@"..\..\..\Resources\Music\pokemonRockPaperScissorsOpeningMusic.wav"));
            }

            else if(drawThisBackground == "resultsScreen")
            {
                drawResultsScreen(e, new SoundPlayer(@"..\..\..\Resources\Music\YouLoseMusic.wav"), new SoundPlayer(@"..\..\..\Resources\Music\YouWinMusic.wav"));
                drawGameResults(e, c.gameResult);
            }

            base.OnPaint(e);

        }



        private void drawGameResults(PaintEventArgs e, String drawString)
        {
            // Create string to draw.
            // drawString = "You are now playing against a CPU. Please select one of the pokemon of your choice!";

            // Create font and brush.
            Font drawFont3 = new Font("Arial", 25);
            SolidBrush drawBrush = new SolidBrush(Color.Black);

            // Create rectangle for drawing.
            float x = 200.0F;
            float y = 0.0F;
            float width1 = 500.0F;
            float height1 = 120.0F;
            RectangleF drawRect = new RectangleF(x, y, width1, height1);

            // Draw rectangle to screen.
            Pen whitePen = new Pen(Color.Black);
            e.Graphics.DrawRectangle(whitePen, x, y, width1, height1);

            // Set format of string.
            StringFormat drawFormat = new StringFormat();
            drawFormat.Alignment = StringAlignment.Center;

            // Draw string to screen.
            e.Graphics.DrawString(drawString, drawFont3, drawBrush, drawRect, drawFormat);
        }


        private void drawCommandPrompt(PaintEventArgs e)
        {
            // Create string to draw.
            String drawString = "You are now playing against a CPU. Please select one of the pokemon of your choice!";

            // Create font and brush.
            Font drawFont3 = new Font("Arial", 25);
            SolidBrush drawBrush = new SolidBrush(Color.White);

            // Create rectangle for drawing.
            float x = 200.0F;
            float y = 0.0F;
            float width1 = 500.0F;
            float height1 = 120.0F;
            RectangleF drawRect = new RectangleF(x, y, width1, height1);

            // Draw rectangle to screen.
            Pen whitePen = new Pen(Color.White);
            e.Graphics.DrawRectangle(whitePen, x, y, width1, height1);

            // Set format of string.
            StringFormat drawFormat = new StringFormat();
            drawFormat.Alignment = StringAlignment.Center;

            // Draw string to screen.
            e.Graphics.DrawString(drawString, drawFont3, drawBrush, drawRect, drawFormat);
        }

        /// <summary>
        /// draws all the instructions for how to play the game in different textboxes containing strings.
        /// </summary>
        /// <param name="e"></param>
        private void drawInstructions(PaintEventArgs e)
        {
            // Create string to draw.
            String drawString = "How To Play: Pokemon Rock Paper Scissors";

            // Create font and brush.
            Font drawFont3 = new Font("Arial", 16);
            SolidBrush drawBrush = new SolidBrush(Color.Black);

            // Create rectangle for drawing.
            float x = 200.0F;
            float y = 0.0F;
            float width1 = 500.0F;
            float height1 = 50.0F;
            RectangleF drawRect = new RectangleF(x, y, width1, height1);

            // Draw rectangle to screen.
            Pen blackPen = new Pen(Color.Black);
            e.Graphics.DrawRectangle(blackPen, x, y, width1, height1);

            // Set format of string.
            StringFormat drawFormat = new StringFormat();
            drawFormat.Alignment = StringAlignment.Center;

            // Draw string to screen.
            e.Graphics.DrawString(drawString, drawFont3, drawBrush, drawRect, drawFormat);







            // Create string to draw.
            String drawString1 = "FOR PEOPLE WHO DON'T KNOW WHAT POKEMON IS OR HOW BASIC POKEMON TYPES WORK:" + '\n' +
                                 "1. Pokemon is a game where you capture pokemon in the wild and raise your own." + '\n' +
                                 "    Through battling with other pokemon, your pokemon will level up and will soon evolve." + '\n' +
                                 "2. Every Pokemon has a certain type (fire, water, grass, etc.)." + '\n' +
                                 "    Some Pokemon of a certain type have an advantage over another pokemon's type." + '\n' +
                                 "    For example, Water type pokemon are strong against fire (and fire is weak to water)." + '\n' +
                                 "    Grass pokemon are strong against water types (and water is weak to grass)" + '\n' +
                                 "    Lastly, Fire pokemon are strong against grass types (and grass is weak to fire)" + '\n' +
                                 "    For this game, you only need to know your type matchups with grass, fire and water.";


            // Create font and brush.
            Font drawFont1 = new Font("Arial", 16);
            SolidBrush drawBrush2 = new SolidBrush(Color.Black);

            // Create rectangle for drawing.
            float x1 = 0.0F;
            float y1 = 100.0F;
            float width2 = 900.0F;
            float height2 = 250.0F;
            RectangleF drawRect1 = new RectangleF(x1, y1, width2, height2);

            // Draw rectangle to screen.
            e.Graphics.DrawRectangle(blackPen, x1, y1, width2, height2);

            // Set format of string.
            StringFormat drawFormat1 = new StringFormat();
            drawFormat.Alignment = StringAlignment.Far;

            // Draw string to screen.
            e.Graphics.DrawString(drawString1, drawFont1, drawBrush2, drawRect1, drawFormat1);







            // Create string to draw.
            String drawString3 = "BASIC RULES:" + '\n' +
                                 "1. When you click the start button from the home screen, there will be a picture of three " + '\n' +
                                 "    different pokemon, which are acutally buttons you can mouse-click on. One is Charizard," + '\n' +
                                 "    a fire type, the red pokemon. Next is Venusaur, a grass type, the green pokemon. Lastly," + '\n' +
                                 "    Blastoise, a water type, the blue pokemon. Using your knowlege of type matchups, you" + '\n' +
                                 "    will be playing rock paper scissors against a CPU. Have fun!" + '\n' +
                                 "SPECIAL THANKS:" + '\n' +
                                 "Carson He and Camron Wilson";
            // Create font and brush.
            Font drawFont4 = new Font("Arial", 16);
            SolidBrush drawBrush3 = new SolidBrush(Color.Black);

            // Create rectangle for drawing.
            float x3 = 0.0F;
            float y3 = 400.0F;
            float width3 = 900.0F;
            float height3 = 230.0F;
            RectangleF drawRect3 = new RectangleF(x3, y3, width3, height3);

            // Draw rectangle to screen.
            e.Graphics.DrawRectangle(blackPen, x3, y3, width3, height3);

            // Set format of string.
            StringFormat drawFormat3 = new StringFormat();
            drawFormat.Alignment = StringAlignment.Far;

            // Draw string to screen.
            e.Graphics.DrawString(drawString3, drawFont4, drawBrush3, drawRect3, drawFormat3);

        }
    }
}

