﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YksikkoTestausDemoo
{
    interface ICalculator
    {
        int Add(int numero1, int numero2);
        int Multiply(int numero1, int numero2);
    }
    //luokka joka toteuttaa ICalculator-rajapinnan
    public class Calculator : ICalculator
    {
        public int Add(int numero1, int numero2)
        {
            return numero1 + numero2;
        }
        public int Multiply(int numero1, int numero2)
        {
            return numero1 + numero2;
        }
    }
    class TestiPeti
    {

    }
  
        static void Main(string[] args)
        {
            //kokeillaan luokkaa Calculator
            Calculator laskin = new YksikkoTestausDemoo.Calculator();
            int tulos = laskin.Add(10, 20);
        }
    }
}
