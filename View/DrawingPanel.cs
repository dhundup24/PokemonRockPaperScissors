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
        bool isBackgroundDrawn = false;


        Image background = Image.FromFile(@"..\..\..\Resources\Images\pokemonGameBackground.png");

        Image battleScreen = Image.FromFile(@"..\..\..\Resources\Images\pokemonGameBattleScreen.png");
        Image gameLogo1 = Image.FromFile(@"..\..\..\Resources\Images\pokemonGameLogo.png");
        Image charizard = Image.FromFile(@"..\..\..\Resources\Images\Charizard.png");
        Image venusaur = Image.FromFile(@"..\..\..\Resources\Images\venusaur.png");
        Image blastoise = Image.FromFile(@"..\..\..\Resources\Images\blastoise.png");
        Image howToPlayButton = Image.FromFile(@"..\..\..\Resources\Images\HowToPlayButton.png");
        Image gameLogo2 = Image.FromFile(@"..\..\..\Resources\Images\PokemonRockPaperScissorsLogo.png");
        Image gameLogo3 = Image.FromFile(@"..\..\..\Resources\Images\PokemonRockPaperScissorsLogo2.png");






        public DrawingPanel()
        {
            this.DoubleBuffered = true;
        }



        public void drawBackground(object o, PaintEventArgs e)
        {
            int width = 900;
            int height = 690;
            e.Graphics.DrawImage(background, 0, 0, width, height);
            e.Graphics.DrawImage(gameLogo1, 240, 150, 400, 170);
            e.Graphics.DrawImage(gameLogo3, 150, 300, 680, 160);


            //CreateGUIButton(o, e, howToPlayButton, 800, 600);
            //e.Graphics.DrawImage(howToPlayButton, 600, 200, 300, 300);
            //e.Graphics.DrawImage(gameLogo2, 300, 200, 300, 300);




            isBackgroundDrawn = true;
        }

        public void drawBattleScreen(object o, PaintEventArgs e)
        {
            
            
            int width = 900;
            int height = 690;
            e.Graphics.DrawImage(battleScreen, 0, 0, width, height);
            charizard = resizeImage(charizard, new Size(300, 280));
            CreateGUIButton(o, e, charizard, 0, 200 );

            venusaur = resizeImage(venusaur, new Size(300, 280));
            CreateGUIButton(o, e, venusaur, 300, 200);

            blastoise = resizeImage(blastoise, new Size(300, 280));
            CreateGUIButton(o, e, blastoise, 600, 200);

            
        }

        public static Image resizeImage(Image imgToResize, Size size)
        {
            return (Image)(new Bitmap(imgToResize, size));
        }


        public void CreateGUIButton(object sender, EventArgs e, Image i, int x, int y)
        {
            Button newButton = new Button();
            
            newButton.Image = i;
            newButton.Size = new Size(270, 270);
            newButton.Location = new Point(x, y);
            this.Controls.Add(newButton);

        }



        protected override void OnPaint(PaintEventArgs e)
        {
            if (isBackgroundDrawn == false)
            {
                drawBackground(background, e);
            }

            else
            {
            drawBattleScreen(battleScreen, e);
            }

            //base.OnPaint(e);
        }
    }
}
