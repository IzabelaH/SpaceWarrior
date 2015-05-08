using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProbaProekt
{
    public class Alien
    {
        /* definiranje na pomestuvanjeto na objektot, pozicijata na koja se naoga, granici na slikata
         * */
        public int Pomestuvanje = 20;
        public Point Pozicija;
        private Bitmap alienImg;
        protected Rectangle GraniciSlika;
        public Rectangle GraniciDvizenje;
        public int Width;
        public int Height;
       public bool izbrisi;
        Random r = new Random();
        public bool iscezni;
        public Alien(int w, int h)
        {
            Width = w;
            Height = h;
            izbrisi = false;
            alienImg = new Bitmap(Properties.Resources.spaceinvaders,new Size(50,50));
            GraniciSlika.Width = alienImg.Width;
            GraniciSlika.Height = alienImg.Height;
            Pozicija.X = r.Next(10,Width-GraniciSlika.Width-10);
            Pozicija.Y = 0;
            GraniciDvizenje = new Rectangle();
            iscezni = false;
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
            return alienImg;
        }
        public Rectangle GetBounds()
        {
            return GraniciDvizenje;
        }

        //azuriranje na momentalnata pozicija na objektot
        public void UpdateGranici()
        {
            GraniciDvizenje = GraniciSlika;
            GraniciDvizenje.Offset(Pozicija);
        }

       

        //pomestuvanje na objektot nadolu
        public void MoveAlien()
        {
            Pozicija.Y += Pomestuvanje;
            if (Pozicija.Y > Height - HeightSlika)
            {
                Pozicija.Y = 0;
            }
                
        }

       
        public void Draw(Graphics g)
        {
            UpdateGranici();
          if(!iscezni)
            g.DrawImage(alienImg, GraniciDvizenje, 0, 0, GraniciSlika.Width, GraniciSlika.Height, GraphicsUnit.Pixel);
                
        }



    }
}
