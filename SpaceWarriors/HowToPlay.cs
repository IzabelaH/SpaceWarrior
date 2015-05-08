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
    public partial class HowToPlay : Form
    {
        public HowToPlay()
        {
            InitializeComponent();
        }

        private void pbstart_Click(object sender, EventArgs e)
        {
            NewGame ng = new NewGame();
            this.Hide();
            ng.Show();
        }

        private void pbquit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void HowToPlay_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

    }
}
