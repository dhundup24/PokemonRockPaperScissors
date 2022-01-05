using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinterBreak2021
{
    public class DrawingPanel : Panel
    {
        public string drawThisBackground;


        Image background = Image.FromFile(@"..\..\..\Resources\Images\pokemonGameBackground.png");

        Image battleScreen = Image.FromFile(@"..\..\..\Resources\Images\pokemonGameBattleScreen.png");
        Image gameLogo1 = Image.FromFile(@"..\..\..\Resources\Images\pokemonGameLogo.png");
        Image charizard = Image.FromFile(@"..\..\..\Resources\Images\Charizard.png");
        Image venusaur = Image.FromFile(@"..\..\..\Resources\Images\venusaur.png");
        Image blastoise = Image.FromFile(@"..\..\..\Resources\Images\blastoise.png");
        Image howToPlayButton = Image.FromFile(@"..\..\..\Resources\Images\HowToPlayButton.png");

        //logo with arch
        Image gameLogo2 = Image.FromFile(@"..\..\..\Resources\Images\PokemonRockPaperScissorsLogo.png");

        //logo without arch
        Image gameLogo3 = Image.FromFile(@"..\..\..\Resources\Images\PokemonRockPaperScissorsLogo2.png");

        Image howToPlayBackground = Image.FromFile(@"..\..\..\Resources\Images\HowToPlayBackground.png");
        Image homeButton = Image.FromFile(@"..\..\..\Resources\Images\homeButton.png");


        public DrawingPanel()
        {
            this.DoubleBuffered = true;
            

        }

        void MyButtonHandler(object sender, EventArgs e)
        {
        }




        public void drawHomeBackground(object o, PaintEventArgs e)
    {
        int width = 900;
        int height = 690;
        e.Graphics.DrawImage(background, 0, 0, width, height);
        e.Graphics.DrawImage(gameLogo1, 240, 150, 400, 170);
        e.Graphics.DrawImage(gameLogo2, 110, 300, 680, 160);

    }

    public void drawBattleScreen(object o, PaintEventArgs e)
    {


        int width = 900;
        int height = 690;
        e.Graphics.DrawImage(battleScreen, 0, 0, width, height);
        charizard = resizeImage(charizard, new Size(300, 280));
        CreateGUIButton(o, e, charizard, 0, 200, new Size(270, 270));

        venusaur = resizeImage(venusaur, new Size(300, 280));
        CreateGUIButton(o, e, venusaur, 300, 200, new Size(270, 270));

        blastoise = resizeImage(blastoise, new Size(300, 280));
        CreateGUIButton(o, e, blastoise, 600, 200, new Size(270, 270));

        homeButton = resizeImage(homeButton, new Size(100, 100));
        CreateGUIButton(o, e, homeButton, 0, 600, new Size(70, 70));


        }

        public void drawHowToPlayScreen(object o, PaintEventArgs e)
    {
        int width = 900;
        int height = 690;
        e.Graphics.DrawImage(howToPlayBackground, 0, 0, width, height);

        homeButton = resizeImage(homeButton, new Size(100, 100));
        CreateGUIButton(o, e, homeButton, 0, 630, new Size(70, 70));

        drawInstructions(e);
    }


    public static Image resizeImage(Image imgToResize, Size size)
    {
        return (Image)(new Bitmap(imgToResize, size));
    }


    public void CreateGUIButton(object sender, EventArgs e, Image i, int x, int y, Size size)
    {
        Button newButton = new Button();

        newButton.Image = i;
        newButton.Size = size;
        newButton.Location = new Point(x, y);
        this.Controls.Add(newButton);

    }


    /// <summary>
    /// onPaint tells the drawingPanel which background to draw
    /// </summary>
    /// <param name="e"></param>
    protected override void OnPaint(PaintEventArgs e)
    {
        if (drawThisBackground == "homeScreen")
        {
            drawHomeBackground(background, e);
        }

        else if (drawThisBackground == "battleScreen")
        {
            drawBattleScreen(battleScreen, e);
        }

        else if (drawThisBackground == "howToPlayScreen")
        {
            drawHowToPlayScreen(howToPlayBackground, e);
        }

        base.OnPaint(e);
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
        Pen blackPen1 = new Pen(Color.Black);
        e.Graphics.DrawRectangle(blackPen1, x1, y1, width2, height2);

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
                             "    will be playing rock paper scissors against a CPU. If the CPU chooses charizard while" + '\n' +
                             "    you choose venusaur, you will lose! Have fun!" + '\n' +
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
        Pen blackPen3 = new Pen(Color.Black);
        e.Graphics.DrawRectangle(blackPen3, x3, y3, width3, height3);

        // Set format of string.
        StringFormat drawFormat3 = new StringFormat();
        drawFormat.Alignment = StringAlignment.Far;

        // Draw string to screen.
        e.Graphics.DrawString(drawString3, drawFont4, drawBrush3, drawRect3, drawFormat3);

    }
}
}

