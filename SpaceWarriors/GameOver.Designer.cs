namespace ProbaProekt
{
    partial class GameOver
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
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pbWinLose = new System.Windows.Forms.PictureBox();
            this.pbGameOver = new System.Windows.Forms.PictureBox();
            this.pbPozadina = new System.Windows.Forms.PictureBox();
            this.pbStart = new System.Windows.Forms.PictureBox();
            this.pbQiut = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWinLose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGameOver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPozadina)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbQiut)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(411, 337);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "lblScore";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ProbaProekt.Properties.Resources.score;
            this.pictureBox2.Location = new System.Drawing.Point(256, 321);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(149, 62);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pbWinLose
            // 
            this.pbWinLose.Location = new System.Drawing.Point(156, 168);
            this.pbWinLose.Name = "pbWinLose";
            this.pbWinLose.Size = new System.Drawing.Size(536, 147);
            this.pbWinLose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbWinLose.TabIndex = 3;
            this.pbWinLose.TabStop = false;
            // 
            // pbGameOver
            // 
            this.pbGameOver.BackgroundImage = global::ProbaProekt.Properties.Resources.IMG_0542;
            this.pbGameOver.Image = global::ProbaProekt.Properties.Resources.gameover1;
            this.pbGameOver.Location = new System.Drawing.Point(156, 12);
            this.pbGameOver.Name = "pbGameOver";
            this.pbGameOver.Size = new System.Drawing.Size(485, 158);
            this.pbGameOver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbGameOver.TabIndex = 1;
            this.pbGameOver.TabStop = false;
            // 
            // pbPozadina
            // 
            this.pbPozadina.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbPozadina.Image = global::ProbaProekt.Properties.Resources.IMG_0542;
            this.pbPozadina.Location = new System.Drawing.Point(0, 0);
            this.pbPozadina.Name = "pbPozadina";
            this.pbPozadina.Size = new System.Drawing.Size(804, 511);
            this.pbPozadina.TabIndex = 0;
            this.pbPozadina.TabStop = false;
            // 
            // pbStart
            // 
            this.pbStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbStart.Image = global::ProbaProekt.Properties.Resources.start;
            this.pbStart.Location = new System.Drawing.Point(97, 424);
            this.pbStart.Name = "pbStart";
            this.pbStart.Size = new System.Drawing.Size(283, 51);
            this.pbStart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbStart.TabIndex = 6;
            this.pbStart.TabStop = false;
            this.pbStart.Click += new System.EventHandler(this.pbStart_Click);
            // 
            // pbQiut
            // 
            this.pbQiut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbQiut.Image = global::ProbaProekt.Properties.Resources.quit;
            this.pbQiut.Location = new System.Drawing.Point(457, 424);
            this.pbQiut.Name = "pbQiut";
            this.pbQiut.Size = new System.Drawing.Size(283, 55);
            this.pbQiut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbQiut.TabIndex = 7;
            this.pbQiut.TabStop = false;
            this.pbQiut.Click += new System.EventHandler(this.pbQiut_Click);
            // 
            // GameOver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 511);
            this.Controls.Add(this.pbQiut);
            this.Controls.Add(this.pbStart);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pbWinLose);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbGameOver);
            this.Controls.Add(this.pbPozadina);
            this.Name = "GameOver";
            this.Text = "Game Over";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GameOver_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWinLose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGameOver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPozadina)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbQiut)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbPozadina;
        private System.Windows.Forms.PictureBox pbGameOver;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbWinLose;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pbStart;
        private System.Windows.Forms.PictureBox pbQiut;
    }
}