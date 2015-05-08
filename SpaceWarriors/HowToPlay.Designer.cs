namespace ProbaProekt
{
    partial class HowToPlay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HowToPlay));
            this.rtbinstructions = new System.Windows.Forms.RichTextBox();
            this.pbalien = new System.Windows.Forms.PictureBox();
            this.pbquit = new System.Windows.Forms.PictureBox();
            this.pbstart = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbalien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbquit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbstart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // rtbinstructions
            // 
            this.rtbinstructions.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.rtbinstructions.BackColor = System.Drawing.Color.Black;
            this.rtbinstructions.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbinstructions.Cursor = System.Windows.Forms.Cursors.Default;
            this.rtbinstructions.Font = new System.Drawing.Font("Kristen ITC", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rtbinstructions.ForeColor = System.Drawing.Color.White;
            this.rtbinstructions.Location = new System.Drawing.Point(47, 92);
            this.rtbinstructions.Name = "rtbinstructions";
            this.rtbinstructions.ReadOnly = true;
            this.rtbinstructions.Size = new System.Drawing.Size(405, 269);
            this.rtbinstructions.TabIndex = 5;
            this.rtbinstructions.TabStop = false;
            this.rtbinstructions.Text = resources.GetString("rtbinstructions.Text");
            // 
            // pbalien
            // 
            this.pbalien.BackgroundImage = global::ProbaProekt.Properties.Resources.IMG_0542;
            this.pbalien.Image = global::ProbaProekt.Properties.Resources.spaceinvaders;
            this.pbalien.Location = new System.Drawing.Point(498, 92);
            this.pbalien.Name = "pbalien";
            this.pbalien.Size = new System.Drawing.Size(225, 249);
            this.pbalien.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbalien.TabIndex = 6;
            this.pbalien.TabStop = false;
            // 
            // pbquit
            // 
            this.pbquit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbquit.Image = global::ProbaProekt.Properties.Resources.quit;
            this.pbquit.Location = new System.Drawing.Point(418, 420);
            this.pbquit.Name = "pbquit";
            this.pbquit.Size = new System.Drawing.Size(283, 55);
            this.pbquit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbquit.TabIndex = 4;
            this.pbquit.TabStop = false;
            this.pbquit.Click += new System.EventHandler(this.pbquit_Click);
            // 
            // pbstart
            // 
            this.pbstart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbstart.Image = global::ProbaProekt.Properties.Resources.start;
            this.pbstart.Location = new System.Drawing.Point(59, 424);
            this.pbstart.Name = "pbstart";
            this.pbstart.Size = new System.Drawing.Size(283, 51);
            this.pbstart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbstart.TabIndex = 3;
            this.pbstart.TabStop = false;
            this.pbstart.Click += new System.EventHandler(this.pbstart_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::ProbaProekt.Properties.Resources.IMG_0542;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(804, 511);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // HowToPlay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 511);
            this.Controls.Add(this.pbalien);
            this.Controls.Add(this.rtbinstructions);
            this.Controls.Add(this.pbquit);
            this.Controls.Add(this.pbstart);
            this.Controls.Add(this.pictureBox1);
            this.Name = "HowToPlay";
            this.Text = "Space Warriors";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HowToPlay_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pbalien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbquit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbstart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pbstart;
        private System.Windows.Forms.PictureBox pbquit;
        private System.Windows.Forms.RichTextBox rtbinstructions;
        private System.Windows.Forms.PictureBox pbalien;
    }
}