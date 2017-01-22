
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Viikkotehtävät
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tehtava1();
            //Tehtava2();
            //Tehtava3();
            //Tehtava4();
            //Tehtava5();
            Tehtava6();
            //Tehtava7();
            //Tehtava8();
            //Tehtava9();
        }

        static void Tehtava1()
        {
            //Tee ohjelma, joka tulostaa käyttäjän antamaa lukua (1, 2 tai 3) vastaavan luvun sanana (yksi, kaksi tai kolme). 
            //Jos käyttäjä syöttää jonkin muun luvun, tulee näytölle tulostaa teksti: "joku muu luku".
            Console.WriteLine("Anna 1, 2 tai 3 ja tulostan sen tekstinä");
            string retval = Console.ReadLine();
            int luku = int.Parse(retval);
            if (luku == 1)
            {
                retval = "yksi";
            }
            if (luku == 2)
            {
                retval = "kaksi";
            }
            if (luku == 3)
            {
                retval = "kolme";
            }
            else
            {
                retval = "Joku muu luku";
            }
            Console.WriteLine(retval);
        }

        static void Tehtava2()
        {
            //Tee ohjelma, jossa annetaan oppilaalle koulunumero seuraavan taulukon mukaan 
            //(pistemäärä kysytään ja ohjelma tulostaa numeron):
            Console.WriteLine("Anna pistemäärä");
            string retval = Console.ReadLine();
            int luku = int.Parse(retval);

            if (luku <= 1 && luku >= 0)
            {
                retval = "Koulunumero on 0";
            }
            if (luku >= 2 && luku <= 3)
            {
                retval = "Koulunumero on 1";
            }
            if (luku >= 4 && luku <= 5)
            {
                retval = "Koulunumero on 2";
            }
            if (luku >= 6 && luku <= 7)
            {
                retval = "Koulunumero on 3";
            }
            if (luku >= 8 && luku <= 9)
            {
                retval = "Koulunumero on 4";
            }
            if (luku >= 10 && luku <= 12)
            {
                retval = "Koulunumero on 5";
            }
            Console.WriteLine(retval);
        }

        static void Tehtava3()
        {
            Console.WriteLine("Syota kolme lukua niin lasken ne yhteen: ");
            string retval = Console.ReadLine();
            int luku1 = int.Parse(retval);

            string retval1 = Console.ReadLine();
            int luku2 = int.Parse(retval1);

            string retval2 = Console.ReadLine();
            int luku3 = int.Parse(retval2);

            int summa = (luku1 + luku2 + luku3);

            Console.WriteLine(summa);
        }

        static void Tehtava4()
        {
            Console.WriteLine("Kuinka vanha olet? ");
            string retval = Console.ReadLine();
            int ika = int.Parse(retval);

            if (ika < 18)
            {
                retval = "Olet alaikainen.";
            }
            else if (ika >= 18 && ika <= 65)
            {
                retval = "Olet aikuinen.";
            }
            else
            {
                retval = "Olet seniori.";
            }
            Console.WriteLine(retval);
        }

        static void Tehtava5()
        {
            //Tee ohjelma, joka näyttää annetun sekuntimäärän tunteina, minuutteina ja sekunteina.
            //Aikamääre sekuntteina kysytään käyttäjältä.
            Console.WriteLine("Anna sekunnit ");
            string retval = Console.ReadLine();
            int sekunnit = int.Parse(retval);
            int minuutti = sekunnit / 60;
            int tunti = sekunnit / 3600;

            Console.WriteLine(tunti + "h | " + (minuutti % 60) + "min | " + (sekunnit % 60) + "s");
        }

        static void Tehtava6()
        {
            Console.WriteLine("Anna matka");
            string retval = Console.ReadLine();
            double matka = double.Parse(retval);

            Console.WriteLine("bensankulutus " + (7.02 / 100 * matka) + " litraa , kustannukset " + (7.02 / 100 * matka * 1.595));
        }

        static void Tehtava7()
        {
            //Tee ohjelma, joka näyttää onko annettu vuosi karkausvuosi. 
            //Vuosiluku kysytään käyttäjältä.
            Console.WriteLine("Anna vuosi");
            string retval = Console.ReadLine();
            int vuosi = int.Parse(retval);

            if (vuosi % 400 == 0)
            {
                Console.WriteLine("Vuosi on karkausvuosi");
            }
            else if (vuosi % 100 == 0)
            {
                Console.WriteLine("Vuosi ei ole karkausvuosi");
            }
            else if (vuosi % 4 == 0)
            {
                Console.WriteLine("Vuosi on karkausvuosi");
            }
            else
            {
                Console.WriteLine("Vuosi ei ole karkausvuosi");
            }
        }

        static void Tehtava8()
        {
            int temp = 0;

            Console.WriteLine("Anna luku ");
            string retval = Console.ReadLine();
            int luku1 = int.Parse(retval);

            Console.WriteLine("Anna luku");
            string retval2 = Console.ReadLine();
            int luku2 = int.Parse(retval2);

            Console.WriteLine("Anna luku");
            string retval3 = Console.ReadLine();
            int luku3 = int.Parse(retval3);

            if (luku3 > luku2)
            {
                luku2 = luku3;
            }
            if (luku2 > luku1)
            {
                luku1 = luku2;
            }
            Console.WriteLine("Suurin luku oli " + luku1);
        }

        static void Tehtava9()
        {
            for (;;)
            {
                string retval = Console.ReadLine();
                int luku = int.Parse(retval);

                Console.WriteLine("Anna luku");

                if (luku != 0)
                {
                    continue;
                }
                if (luku == 0)
                {
                    break;
                }
            }
        }
    }
}
