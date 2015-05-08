namespace ProbaProekt
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
            this.pbime = new System.Windows.Forms.PictureBox();
            this.pbquit = new System.Windows.Forms.PictureBox();
            this.pbhowto = new System.Windows.Forms.PictureBox();
            this.pbstart = new System.Windows.Forms.PictureBox();
            this.pbalien = new System.Windows.Forms.PictureBox();
            this.pbpozadina = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbquit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbhowto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbstart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbalien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbpozadina)).BeginInit();
            this.SuspendLayout();
            // 
            // pbime
            // 
            this.pbime.BackgroundImage = global::ProbaProekt.Properties.Resources.IMG_0542;
            this.pbime.Image = global::ProbaProekt.Properties.Resources.ime;
            this.pbime.Location = new System.Drawing.Point(295, -2);
            this.pbime.Name = "pbime";
            this.pbime.Size = new System.Drawing.Size(509, 202);
            this.pbime.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbime.TabIndex = 5;
            this.pbime.TabStop = false;
            // 
            // pbquit
            // 
            this.pbquit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbquit.Image = global::ProbaProekt.Properties.Resources.quit;
            this.pbquit.Location = new System.Drawing.Point(461, 398);
            this.pbquit.Name = "pbquit";
            this.pbquit.Size = new System.Drawing.Size(283, 55);
            this.pbquit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbquit.TabIndex = 4;
            this.pbquit.TabStop = false;
            this.pbquit.Click += new System.EventHandler(this.pbquit_Click);
            // 
            // pbhowto
            // 
            this.pbhowto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbhowto.Image = global::ProbaProekt.Properties.Resources.how;
            this.pbhowto.Location = new System.Drawing.Point(461, 300);
            this.pbhowto.Name = "pbhowto";
            this.pbhowto.Size = new System.Drawing.Size(281, 54);
            this.pbhowto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbhowto.TabIndex = 3;
            this.pbhowto.TabStop = false;
            this.pbhowto.Click += new System.EventHandler(this.pbhowto_Click);
            // 
            // pbstart
            // 
            this.pbstart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbstart.Image = global::ProbaProekt.Properties.Resources.start;
            this.pbstart.Location = new System.Drawing.Point(461, 206);
            this.pbstart.Name = "pbstart";
            this.pbstart.Size = new System.Drawing.Size(283, 51);
            this.pbstart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbstart.TabIndex = 2;
            this.pbstart.TabStop = false;
            this.pbstart.Click += new System.EventHandler(this.pbstart_Click);
            // 
            // pbalien
            // 
            this.pbalien.BackgroundImage = global::ProbaProekt.Properties.Resources.IMG_0542;
            this.pbalien.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbalien.Image = ((System.Drawing.Image)(resources.GetObject("pbalien.Image")));
            this.pbalien.Location = new System.Drawing.Point(30, 195);
            this.pbalien.Name = "pbalien";
            this.pbalien.Size = new System.Drawing.Size(400, 271);
            this.pbalien.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbalien.TabIndex = 1;
            this.pbalien.TabStop = false;
            // 
            // pbpozadina
            // 
            this.pbpozadina.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbpozadina.Image = global::ProbaProekt.Properties.Resources.IMG_0542;
            this.pbpozadina.Location = new System.Drawing.Point(0, 0);
            this.pbpozadina.Name = "pbpozadina";
            this.pbpozadina.Size = new System.Drawing.Size(804, 511);
            this.pbpozadina.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbpozadina.TabIndex = 0;
            this.pbpozadina.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 511);
            this.Controls.Add(this.pbime);
            this.Controls.Add(this.pbquit);
            this.Controls.Add(this.pbhowto);
            this.Controls.Add(this.pbstart);
            this.Controls.Add(this.pbalien);
            this.Controls.Add(this.pbpozadina);
            this.Name = "Form1";
            this.Text = "Space Warriors";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pbime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbquit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbhowto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbstart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbalien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbpozadina)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbpozadina;
        private System.Windows.Forms.PictureBox pbalien;
        private System.Windows.Forms.PictureBox pbstart;
        private System.Windows.Forms.PictureBox pbhowto;
        private System.Windows.Forms.PictureBox pbquit;
        private System.Windows.Forms.PictureBox pbime;
    }
}

