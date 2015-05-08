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
    public partial class NewGame : Form
    {
        /*
         * definiranje na objekt od klasata Spacedocument i postavuvanje na ogranicuvanjeto za vremetraenjeto na igrata
         * */
        public SpaceDocument space;
        public int timeLeft=120;
        
        public NewGame()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            space = new SpaceDocument(Width,Height);
            /*
             * startuvanje na timerAlines koj vremenski se odreduva koga da se generira nov objekt od klasata Alien 
             * i  startuvanje na timerVreme koj go odbrojuva preostanatoto vreme za igranje
             * */
            timerAliens.Start();
            timerVreme.Start();
          
            
           
        }

        private void pbpozadina_Paint(object sender, PaintEventArgs e)
        {
            space.Draw(e.Graphics);
            space.ship.DrawExplosion(e.Graphics);
        }

        /*
         *  pridvizuvanje na objektot ship pri pritiskanje na kopcinjata za pridvizuvanje na levo i na desno soodvetno
         * */
        private void NewGame_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                space.ship.MoveLeftShip();
            }
            if (e.KeyCode == Keys.Right)
            {
                space.ship.MoveRightShip();
            }
         
            Invalidate(true);
        }

        //generiranje na nov objekt od klasata Alien, negovo pridvizuvanje i prikaz na momentalniot broj na zivoti 
        private void timerAliens_Tick(object sender, EventArgs e)
        {
            Alien a = new Alien(Width,Height);
            space.AddAlien(a);
            foreach (Alien alien in space.aliens)
            {
                alien.MoveAlien();

                
            }
            space.updateIzcesni();
            lblZivoti.Text = space.ship.Zivoti.ToString();
            
          
            Invalidate(true);
        }


        /*pukanje od objektot ship pri pritiskanje na kopceto Space od tastatura
        i povik na funkcijata koja proveruva dali nastanala kolizija
         */
        private void NewGame_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar== (char)Keys.Space)
            {
                space.ship.updatePukaj();
                space.ship.playMachineGun();
                space.areTouching();
            }
            Invalidate(true);
        }

        //timer kojsto go odbrojuva vremeto i proveruva dali nastanal kraj na igrata
        private void timerVreme_Tick(object sender, EventArgs e)
        {
            timeLeft--;
            if (space.ship.Ziv == false)
            {
                gameOver();
            }

            if (timeLeft == 0)
            {
               
                
                gameOver();
            }
        }

        //funkcija so koja se zapiraat tajmerite i se prikazuva interfejsot so ishodot od igrata
        private void gameOver()
        {
            timerAliens.Stop();
            timerVreme.Stop();
            GameOver go = new GameOver(space.score,space.ship.Ziv);
            this.Hide();
            go.Show();
            

        }

        private void NewGame_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

       

       

     
    }
}
