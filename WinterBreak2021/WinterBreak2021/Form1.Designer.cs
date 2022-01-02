
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
            this.pokemonGameStartButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pokemonGameStartButton
            // 
            this.pokemonGameStartButton.Image = ((System.Drawing.Image)(resources.GetObject("pokemonGameStartButton.Image")));
            this.pokemonGameStartButton.Location = new System.Drawing.Point(347, 436);
            this.pokemonGameStartButton.Name = "pokemonGameStartButton";
            this.pokemonGameStartButton.Size = new System.Drawing.Size(219, 82);
            this.pokemonGameStartButton.TabIndex = 0;
            this.pokemonGameStartButton.UseVisualStyleBackColor = true;
            this.pokemonGameStartButton.Click += new System.EventHandler(this.pokemonGameStartButton_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1217, 871);
            this.Controls.Add(this.pokemonGameStartButton);
            this.Name = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button pokemonGameStartButton;
    }
}

