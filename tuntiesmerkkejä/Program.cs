using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JAMK.IT;

namespace tuntiesmerkkejä
{
    class Program
    {
        static void Main(string[] args)
        {
            Lab05Teht01();

        }
        static void Lab05Teht01()
        {
            //luodaan ensimmäinen ajoneuvo
            Vehicle auto = new JAMK.IT.Vehicle();
            auto.Brand = "BMW";
            auto.Model = "320";
            //ostetaan parit renkaat
            Tyre rinkula = new Tyre();
            rinkula.Branch = "Hankook";
            rinkula.Size = "205/55R16";
            //laitetaan bemariin taakse renkaat
            auto.AddTyre(rinkula);
            auto.AddTyre(rinkula);

            //näytetääs auton tiedot
            Console.WriteLine("Autossasi {0} on seuraavat tiedot: {1}", auto.Brand, auto.ToString());
        }
    }
}
