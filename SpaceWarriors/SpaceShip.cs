using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace ProbaProekt
{
    public class SpaceShip
    {
        /* definiranje na pomestuvanjeto na objektot, pozicijata na koja se naoga, granici na slikata
        * */
        public int Pomestuvanje = 5;
        public bool Ziv;
        public Point Pozicija;
        private Bitmap shipImg;
        public int Zivoti;
        protected Rectangle GraniciSlika;
        public Rectangle GraniciDvizenje;
        public int Width;
        public int Height;
        public bool pukaj;
        public bool dopreno;
       private SoundPlayer MachineGun;
      

        public SpaceShip(int w, int h)
        {
            Width = w;
            Height = h;

            Ziv = true;
            shipImg = new Bitmap(Properties.Resources.Space_Invaders_cannon);
            Zivoti = 3;
            GraniciSlika.Width = shipImg.Width;
            GraniciSlika.Height = shipImg.Height;
            Pozicija.X = Width / 2 - GraniciSlika.Width / 2;
            Pozicija.Y = Height - GraniciSlika.Height - 35;
            GraniciDvizenje = new Rectangle();
            pukaj = false;
            dopreno = false;
            MachineGun = new SoundPlayer(Properties.Resources.Laser_SoundBible_com_602495617);
           

        }

        public int WidthSlika
        {
            get
            {
                return GraniciSlika.Width;
            }
        }

        public int HeightSlika
        {
            get
            {
                return GraniciSlika.Height;
            }
        }

        public Image GetImage()
        {
            return shipImg;
        }
        public Rectangle GetBounds()
        {
            return GraniciDvizenje;
        }
        public void UpdateGranici()
        {
            GraniciDvizenje = GraniciSlika;
            GraniciDvizenje.Offset(Pozicija);
        }



        public void updatePukaj()
        {
            pukaj = !pukaj;
        }

        //presmetuvanje na vrednosta na tockata od koja ke se iscrta pukanjeto
        public Point StartPukanje()
        {
            Point start = new Point(GraniciDvizenje.Left + GraniciDvizenje.Width / 2,
               GraniciDvizenje.Top - 10);

            return start;

        }

        //iscrtuvanje na linijata so koja se prikazuva pukanjeto
        public void DrawExplosion(Graphics g)
        {
            if (pukaj)
            {
                Pen p = new Pen(Color.Green, 3);
                g.DrawLine(p, StartPukanje(), new Point(StartPukanje().X, 0));
                p.Dispose();
                pukaj = !pukaj;
               
            }
            
           
        }

        //azuriranje na brojot na zivoti 
        public void updateZiv() {
            if (dopreno)
            {
                Zivoti-=1;
                dopreno = !dopreno;
            }
            if (Zivoti == 0)
            {
                Ziv = false;

            }
           

           
        }

        //funkcii za pomestuvanje na objektot desno i levo soodvetno
        public void MoveRightShip()
        {
            Pozicija.X += Pomestuvanje;
            if (Pozicija.X > Width - WidthSlika)
                Pozicija.X = Width - WidthSlika;
        }

        public void MoveLeftShip()
        {
            Pozicija.X -= Pomestuvanje;
            if (Pozicija.X < 0)
                Pozicija.X = 0;
        }


        public void Draw(Graphics g)
        {
            if (!Ziv)
            {
                return;
            }
            else
            {
 
                    UpdateGranici();
                    g.DrawImage(shipImg, GraniciDvizenje, 0, 0, GraniciSlika.Width, GraniciSlika.Height, GraphicsUnit.Pixel);

                 
            }
        }
        //funkcija za zvucen signal pri pukanje
        public void playMachineGun()
        {
            
            MachineGun.Play();
        }
     

    }
}
