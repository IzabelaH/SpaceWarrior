Space Warriors
===================


Проектот претставува модификација на играта Space Invaders. Играта е од забавен карактер во која корисникот ја зема улогата на вселенско летало кое треба да ги елиминира вонземјаните со што ќе се здобие со поени за секоја елиминација. Победа во играта може да се постигне доколку играчот успее да остане со барем еден живот којшто се губи само доколку некој вонземјанин го допре леталото. Доколку играчот успее да задржи барем еден живот до истек на времето коешто е ограничено со тајмер, излегува како победник од играта, а во спротнивно ја губи играта.
Кодот на играта се состои од четири форми (Form1-почетен интерфејс на играта, каде играчот може да избере дали да ја започне играта, да се запознае со начинот на кој се игра играта или да ја напушти; NewGame-интерфејс во којшто се игра играта; HowToPlay-интерфејс во којшто се опишани правилата на играта и GameOver-интерфејс во кој е прикажан исходот од играта)  и три класи (SpaceShip,Alien,SpaceDocument).
Во класата SpaceShip и во класата Alien се дефинираат позициите на која ќе се наоѓаат објектите од овие класи.  Во класата SpaceShip се чуваат информации за сликата, состојбата на објектот т.е бројот на преостанати животи. Во оваа класа ги имплементираме методите за пукање и поместување на објектот.
Во класата  SpaceDocument се чува објект од класата SpaceShip и листа од објекти на класата Alien, како и моменталниот резултат. Во оваа класа се имплементирани методите за проверка дали леталото е допрено од некој вонземјанин и соодветно ажурирање на животите. Исто така тука е имплементиран методот со којшто се убиваат вонземјаните.



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

 Во овој метод преку проверка на променливата пукај одредуваме дали да се изврши изминување на сите објекти од листата aliens и да се провери дали треба да биде отстранет од самата листа и соодветно да се зголеми бројот на освоени поени.

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
        /*
        funkcija koja azurira koja ja odreduva sostojbata na ship i objektite od listata i
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

Функцијата public void updateIzcesni() се повикува  на секој тик на тајмерот и проверува дали настанала колизија на некој објект од листата aliens I објектот ship и ги ажурира променливите iscezni и dopreno соодветно. Исто така се прави повик кон функциите updateZiv() којшто ги ажурира животите доколку е потребно и RemoveAlien() која ги отстранува сите објекти чијашто променлива iscezni е поставена на true.

Функцијата public bool isKilled(Rectangle r1, Rectangle r2) прима два аргументи, правоаголник којшто ги претставува границите на еден објект и правоаголник кој ги претставува границите на другиот објект и преку готовата  функција intersect дали настанува пресек помеѓу нив.

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

Тајмер којшто на секој тик генерира нов објект од класата Alien и го додава во листата и за сите елементи од листата го повикува методот MoveAlien() којшто ги придвижува сите објекти. Тука исто така се повикуваат функцијата за ажурирање на животите на објектот space и соодветно прикажување во лабела.

Правила на играта
Вселенското летало е клучниот објект во играта којшто се придвижува лево и десно преку интеракција на корисникот со притискање на стрелките од тастатура. Исто така вселенското летало може да пука со притискање на копчето Space од тастатурата. Целта е да се убијат што е можно поголем број на вонземјани за што за секој убиен се добиваат по 10 поени. Играта ќе заврши само доколку бројот на животи на вселенското летало е еднаков на 0 или доколку истече времето предвидено за игра.

Почетниот интерфејс на играта е следниот:
![Alt text](https://github.com/IzabelaH/SpaceWarrior/blob/master/SpaceWarriors/Recources/pocetok.png)

