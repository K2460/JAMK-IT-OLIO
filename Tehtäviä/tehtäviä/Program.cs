using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tehtäviä
{
    class Program
    {
        static void Main(string[] args)
        {
            //Harjoitus1();
            //Harjoitus3();
            //Harjoitus4();
            //Harjoitus5();
            //Harjoitus6();
            //Harjoitus8();
            Harjoitus9();
            //Harjoitus10();
        }
        static void Harjoitus1()
        {
            Console.WriteLine("Anna luku 1, 2 tai 3");
            int luku = Int32.Parse(Console.ReadLine());
            if (luku == 1)
            {
                Console.WriteLine("yksi");
            }
            else if (luku == 2)
            {
                Console.WriteLine("kaksi");
            }
            else if (luku == 3)
            {
                Console.WriteLine("kolome");
            }
            else
            {
                Console.WriteLine("joku muu luku");
            }
        }
        static void Harjoitus4()
        {
            Console.WriteLine("Anna ikäsi");
            int ika = Int32.Parse(Console.ReadLine());
            if (ika < 18)
            {
                Console.WriteLine("Olet alaikäinen");
            }
            else if (ika >= 18 && ika <= 65)
            {
                Console.WriteLine("Olet aikuinen");
            }
            else
            {
                Console.WriteLine("Olette seniori");
            }
        }
        static void Harjoitus5()
        {
            Console.WriteLine("Annappa sekunteja niin näytän ne tunteina, minuutteina ja sekunteina");
            int sekunnit = int.Parse(Console.ReadLine());
            int minuutit = sekunnit / 60;
            int tunnit = sekunnit / 3600;

            Console.WriteLine(tunnit + " tuntia " + (minuutit % 60) + " minuuttia " + (sekunnit % 60) + " sekuntia ");
        }
        static void Harjoitus6()
        {
            Console.WriteLine("Anna kuljettu matka kilometreinä");
            double kilometrit = double.Parse(Console.ReadLine());

            Console.WriteLine("Bensankulutus " + (7.02 / 100 * kilometrit) + " litraa, rahanmenetys " + (7.02 / 100 * kilometrit * 1.595));
        }
        static void Harjoitus3()
        {
            Console.WriteLine("Anna kolme lukua. Tulostan summan ja ka:n");
            int luku1 = Int32.Parse(Console.ReadLine());
            int luku2 = Int32.Parse(Console.ReadLine());
            int luku3 = Int32.Parse(Console.ReadLine());

            int summa = (luku1 + luku2 + luku3);

            int keskiarvo = (summa / 3);

            Console.WriteLine("summa " + summa + " ja keskiarvo " + keskiarvo);
        }
        static void Harjoitus8()
        {
            Console.Clear();
            Console.Write("Anna kokonaisluku > ");
            int luku1 = Int32.Parse(Console.ReadLine());

            Console.Write("Anna kokonaisluku > ");
            int luku2 = Int32.Parse(Console.ReadLine());

            Console.Write("Anna kokonaisluku > ");
            int luku3 = Int32.Parse(Console.ReadLine());

            if (luku1 > luku2 && luku1 > luku3)
            {
                Console.WriteLine("Suurin luku on: " + luku1);
            }
            else if (luku2 > luku1 && luku2 > luku3)
            {
                Console.WriteLine("Suurin luku on: " + luku2);
            }
            else if (luku3 > luku1 && luku3 > luku2)
            {
                Console.WriteLine("Suurin luku on: " + luku3);
            }
        }
        static void Harjoitus9()
        {
            Console.Clear();
            Console.WriteLine("Summalaskin. Anna lukuja ja lopuksi luku 0 niin tulostan summan.");
            List<int> luvut = new List<int>();
            for (int x = 1; ; x++)
            {
                Console.WriteLine("Anna luku " + x + ": ");
                int syote = int.Parse(Console.ReadLine());
                if (syote == 0)
                {
                    break;
                }
                else
                {
                    luvut.Add(syote);
                }
            }
            //TULOSTAA LUKUJEN SUMMAN
            Console.WriteLine("Lukujen summa on: " + luvut.Sum());
        }
        static void Harjoitus10()
        {

        }
    }
}
