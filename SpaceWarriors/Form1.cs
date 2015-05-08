using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProbaProekt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void pbquit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pbstart_Click(object sender, EventArgs e)
        {
            NewGame ng = new NewGame();
            this.Hide();
            ng.Show();
           
            
        }

        private void pbhowto_Click(object sender, EventArgs e)
        {
            HowToPlay hp = new HowToPlay();
            this.Hide();
            hp.Show();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

       
    }
}
