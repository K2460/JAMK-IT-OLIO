﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTV16S4
{
    class Car
    {
        //property = ominaisuus, ominaisuudet aina julkisia
        //näinkin voi tehdä mutta vältä
        //public int Speed;
        public int Horsepower { get; set; }
        //sisäinen vakio määrittelee maksiminopeuden joka oliolle voidaan asettaa
        private const int maxSpeed = 200; //const tarkoittaa vakiota
        private int speed;
        public int Speed

        {
            //get-aksessori palauttaa propertylle arvon
            get
            {
                return speed;
            }
            //set-aksessorilla asetetaan propertyn arvoa
            set
            {
                if (value > maxSpeed)
                  speed = maxSpeed;
                else 
                  speed = value;
            }
        }
        public string Brand { get; set; }
        //constructors
        public Car ()
        //oletuskonstruktori
        { }
        public Car (int horsepower, int speed)
        {
            Horsepower = horsepower;
            if (speed < maxSpeed)
                this.speed = speed; // this viittaa olioon itseensä
            else
                this.speed = maxSpeed;
        }
        //methods
        public void Accelerate(int addition)
        {
            //kiihdytetään autoa mutta ei yli maksiminopeuden
            if (speed + addition < maxSpeed)
                speed = speed + addition;
            else
                speed = maxSpeed;
        }
        public override string ToString()
        {
            return Brand + " hv:" + Horsepower + "nopeus:" + speed; 
        }
    }
    class Program
    {
        static void TestMyCarClass()
        {
            //luodaan Car- olio
            Car car = new TTV16S4.Car();
            car.Brand = "Toyota";
            car.Horsepower = 120;
            car.Speed = 175;
            //luodaan toinen pirssi
            Car car2 = new Car();
            car2.Brand = "Porche";
            car2.Horsepower = 300;
            car2.Speed = 250;
            //luodaan kolmas pikkufiiu
            Car fiat = new Car(55, 205);
            //näytetään konsolilla
            Console.WriteLine("Ensimmäinen auto {0}", car.ToString());
            Console.WriteLine("Autosi {1} nopeus on {0}", car.Speed, car.Brand);
            Console.WriteLine("Autosi {1} nopeus on {0}", car2.Speed, car2.Brand);
            Console.WriteLine("Autosi {1} nopeus on {0}", fiat.Speed, fiat.Brand);
            //kiihdytetään kumpaakin autoa 20km/h
            car.Accelerate(20);
            car2.Accelerate(20);
            fiat.Accelerate(20);
            Console.WriteLine("Kiihdytettiin 20km/h");
            Console.WriteLine("Autosi 1 nopeus on {0}", car.Speed);
            Console.WriteLine("Autosi 2 nopeus on {0}", car2.Speed);
            Console.WriteLine("Autosi fiat nopeus on {0}", fiat.Speed);

        }
        static void Main(string[] args)
        {
            TestMyCarClass();
        }
    }
}
