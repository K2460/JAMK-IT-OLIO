using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demot
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        static void OOIkkunaDemo()
        {
            // ohjelma laskee ikkunan pinta-alan ja piirin
            float Leveys = 0;
            float Korkeus = 0;
            float Ala, Piiri = 0;
            //kysytään käyttäjältä mitat
            Console.WriteLine("Lasken ikkunan pinta-alan ja piirin, syötä ikkunan leveys millimetreinä");
            Leveys = float.Parse(Console.ReadLine());
            Console.WriteLine("Anna korkeus millimetreinä");
            Korkeus = float.Parse(Console.ReadLine());
            //lasketaan pinta-ala ja piiri ja ilmoitetaan ne käyttäjälle
            Ala = Leveys * Korkeus;
            Piiri = 2 * (Leveys + Korkeus);
            Console.WriteLine("Ikkunan ala {0} ja piiri {-1}", Ala, Piiri);

        }
    }
}
