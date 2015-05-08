using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProbaProekt
{
    public class SpaceDocument
    {
        /* definiranje na objekt od klasata SpaceShip i niza na objekti od klasata Alien
         * */
        public SpaceShip ship;
        public List<Alien> aliens;
        public int Width;
        public int Height;

        public int score;

        public SpaceDocument(int width, int height)
        {
            Width = width;
            Height = height;
            ship = new SpaceShip(Width, Height);
            aliens = new List<Alien>();
            score = 0;

        }

        public void AddAlien(Alien a)
        {
            aliens.Add(a);
        }

        public void Draw(Graphics g)
        {
            ship.Draw(g);

            foreach (Alien al in aliens)
            {

                al.Draw(g);
            }
        }

        /*
         * metod koj proveruva dali pri pukanje nastanuva kolizija so nekoj objekt od listata aliens
         * i povik kon funkcija koja gi presmetuva poenite
         * */
        public void areTouching()
        {
            if (ship.pukaj)
                for (int i = 0; i < aliens.Count; i++)
                {
                    if ((ship.StartPukanje().X >= aliens[i].Pozicija.X) && (ship.StartPukanje().X <= (aliens[i].Pozicija.X + aliens[i].WidthSlika)))
                    {
                        aliens[i].iscezni = true;
                        CountScore();

                    }

                }

            RemoveAlien();
        }

         /*
         * funkcija koja proveruva dali nastanal sudir pomegu ship i nekoj od objektite od listata aliens
         * */
        public bool isKilled(Rectangle r1, Rectangle r2)
        {
            Rectangle intersect = Rectangle.Intersect(r1, r2);

            if (intersect != Rectangle.Empty)
            {
                return true;
            }

            return false;
        }

        /*funkcija koja azurira koja ja odreduva sostojbata na ship i objektite od listata i
        soodvetno odreduva dali sekoj od niv treba da se iscrta
         */
        public void updateIzcesni()
        {
            foreach (Alien al in aliens)
            {
                if (isKilled(al.GraniciDvizenje, ship.GraniciDvizenje))
                {
                    ship.dopreno = true;
                    al.iscezni = true;


                }

                ship.updateZiv();


            }
            RemoveAlien();
        }


        
        public void RemoveAlien()
        {
            for (int i = 0; i < aliens.Count; i++)
            {
                if (aliens[i].iscezni)
                {

                    aliens.RemoveAt(i);
                }
            }
        }

        //funkcija za presmetuvanje na poenite
        public void CountScore()
        {

            if (!ship.dopreno)
            {
                score += 10;
            }
        }

       



    }

}

