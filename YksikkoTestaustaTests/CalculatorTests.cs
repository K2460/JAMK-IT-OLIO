using Microsoft.VisualStudio.TestTools.UnitTesting;
using YksikkoTestausta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YksikkoTestausta.Tests
{
    [TestClass()]

    public class CalculatorTests
    {
        [TestMethod()]
        public void AddTestZero()
        {
            //AAA-periaate
            //arrange = alustus, valmistelu
            Calculator calc = new Calculator();
            int n1 = 5;
            int n2 = 8;
            int expected = 13;
            //act = toimi
            int actual = calc.Add(n1, n2);
            //assert = tarkistus
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void MultiplyTest()
        {
            //AAA-periaate
            //arrange = alustus, valmistelu
            Calculator calc = new Calculator();
            int n1 = 5;
            int n2 = 8;
            int expected = 40;
            //act = toimi
            int actual = calc.Multiply(n1, n2);
            //assert = tarkistus
            Assert.AreEqual(expected, actual);
        }
    }
}