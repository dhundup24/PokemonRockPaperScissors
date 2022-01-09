
namespace WinterBreak2021
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gameLogo2 = new System.Windows.Forms.Label();
            this.RockPaperScissorsLogo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // gameLogo2
            // 
            this.gameLogo2.AutoSize = true;
            this.gameLogo2.Location = new System.Drawing.Point(401, 284);
            this.gameLogo2.Name = "gameLogo2";
            this.gameLogo2.Size = new System.Drawing.Size(0, 25);
            this.gameLogo2.TabIndex = 2;
            // 
            // RockPaperScissorsLogo
            // 
            this.RockPaperScissorsLogo.AutoSize = true;
            this.RockPaperScissorsLogo.Image = ((System.Drawing.Image)(resources.GetObject("RockPaperScissorsLogo.Image")));
            this.RockPaperScissorsLogo.Location = new System.Drawing.Point(401, 323);
            this.RockPaperScissorsLogo.Name = "RockPaperScissorsLogo";
            this.RockPaperScissorsLogo.Size = new System.Drawing.Size(0, 25);
            this.RockPaperScissorsLogo.TabIndex = 3;
            this.RockPaperScissorsLogo.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1217, 871);
            this.Controls.Add(this.RockPaperScissorsLogo);
            this.Controls.Add(this.gameLogo2);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label gameLogo2;
        private System.Windows.Forms.Label RockPaperScissorsLogo;
    }
}

