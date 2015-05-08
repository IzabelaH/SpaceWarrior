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
    public partial class GameOver : Form
    {
        public GameOver(int score,bool ziv)
        {
            InitializeComponent();
            label1.Text = score.ToString();
            if (ziv)
            {
                pbWinLose.Image = Properties.Resources.winner;
            }
            else
            {
                pbWinLose.Image = Properties.Resources.YOU_LOSE;
            }

        }

        private void pbQiut_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pbStart_Click(object sender, EventArgs e)
        {
            NewGame ng = new NewGame();
            this.Hide();
            ng.Show();
        }

        private void GameOver_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

       
    }
}
