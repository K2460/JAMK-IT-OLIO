using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YksikkoTestausta
{
    interface ICalculator
    {
        int Add(int numero1, int numero2);
        int Multiply(int numero1, int numero2);
    }
    //Luokka joka toteuttaa ICalculator-rajapinnan
    public class Calculator : ICalculator
    {
        public int Add(int numero1, int numero2)
        {
            return numero1 + numero2;
        }
        public int MultiplyTest(int numero1, int numero2)
        {
            return numero1 * numero2;
        }
    }
    class TestiPeti
    {
        static void Main(string[] args)
        {
            //Kokeillaan luokkaa Calculator
            Calculator laskin = new YksikkoTestausta.Calculator();
            int tulos = laskin.Add(10, 20);
            Console.WriteLine("Yhteenlaskun 10+20 tulos on:" + tulos);

        }
    }
}