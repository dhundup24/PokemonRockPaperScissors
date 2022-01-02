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
        //bool isBattleScreenDrawn = false;

        Image background = Image.FromFile(@"..\..\..\Resources\Images\pokemonGameBackground.png");

        Image battleScreen = Image.FromFile(@"..\..\..\Resources\Images\pokemonGameBattleScreen.png");
        Image gameLogo = Image.FromFile(@"..\..\..\Resources\Images\pokemonGameLogo.png");
        Image charizard = Image.FromFile(@"..\..\..\Resources\Images\Charizard.png");
        Image venusaur = Image.FromFile(@"..\..\..\Resources\Images\venusaur.png");
        Image blastoise = Image.FromFile(@"..\..\..\Resources\Images\blastoise.png");



        public DrawingPanel()
        {
            this.DoubleBuffered = true;
        }



        public void drawBackground(object o, PaintEventArgs e)
        {
            int width = 900;
            int height = 690;
            e.Graphics.DrawImage(background, 0, 0, width, height);
            e.Graphics.DrawImage(gameLogo, 250, 150, 400, 170);


            isBackgroundDrawn = true;
        }

        public void drawBattleScreen(object o, PaintEventArgs e)
        {
            
            
            int width = 900;
            int height = 690;
            e.Graphics.DrawImage(battleScreen, 0, 0, width, height);
            //e.Graphics.DrawImage(charizard, -50, 200, 400, 300);
            //e.Graphics.DrawImage(venusaur, 300, 200, 300, 300);
            //e.Graphics.DrawImage(blastoise, 600, 200, 300, 300);



            //isBattleScreenDrawn = true;
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

            base.OnPaint(e);
        }
    }
}
