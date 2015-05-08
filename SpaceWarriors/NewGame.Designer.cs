namespace ProbaProekt
{
    partial class NewGame
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
            this.components = new System.ComponentModel.Container();
            this.timerAliens = new System.Windows.Forms.Timer(this.components);
            this.timerVreme = new System.Windows.Forms.Timer(this.components);
            this.pbpozadina = new System.Windows.Forms.PictureBox();
            this.lblZivotiTekst = new System.Windows.Forms.Label();
            this.lblZivoti = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbpozadina)).BeginInit();
            this.SuspendLayout();
            // 
            // timerAliens
            // 
            this.timerAliens.Interval = 700;
            this.timerAliens.Tick += new System.EventHandler(this.timerAliens_Tick);
            // 
            // timerVreme
            // 
            this.timerVreme.Interval = 1000;
            this.timerVreme.Tick += new System.EventHandler(this.timerVreme_Tick);
            // 
            // pbpozadina
            // 
            this.pbpozadina.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbpozadina.Image = global::ProbaProekt.Properties.Resources.IMG_0542;
            this.pbpozadina.Location = new System.Drawing.Point(0, 0);
            this.pbpozadina.Name = "pbpozadina";
            this.pbpozadina.Size = new System.Drawing.Size(804, 511);
            this.pbpozadina.TabIndex = 0;
            this.pbpozadina.TabStop = false;
            this.pbpozadina.Paint += new System.Windows.Forms.PaintEventHandler(this.pbpozadina_Paint);
            // 
            // lblZivotiTekst
            // 
            this.lblZivotiTekst.AutoSize = true;
            this.lblZivotiTekst.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblZivotiTekst.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblZivotiTekst.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblZivotiTekst.Location = new System.Drawing.Point(12, 4);
            this.lblZivotiTekst.Name = "lblZivotiTekst";
            this.lblZivotiTekst.Size = new System.Drawing.Size(64, 25);
            this.lblZivotiTekst.TabIndex = 1;
            this.lblZivotiTekst.Text = "Lives:";
            // 
            // lblZivoti
            // 
            this.lblZivoti.AutoSize = true;
            this.lblZivoti.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblZivoti.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblZivoti.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblZivoti.Location = new System.Drawing.Point(82, 9);
            this.lblZivoti.Name = "lblZivoti";
            this.lblZivoti.Size = new System.Drawing.Size(0, 20);
            this.lblZivoti.TabIndex = 2;
            this.lblZivoti.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // NewGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 511);
            this.Controls.Add(this.lblZivoti);
            this.Controls.Add(this.lblZivotiTekst);
            this.Controls.Add(this.pbpozadina);
            this.Name = "NewGame";
            this.Text = "Space Warriors";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NewGame_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NewGame_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NewGame_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.pbpozadina)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbpozadina;
        private System.Windows.Forms.Timer timerAliens;
        private System.Windows.Forms.Timer timerVreme;
        private System.Windows.Forms.Label lblZivotiTekst;
        private System.Windows.Forms.Label lblZivoti;
    }
}