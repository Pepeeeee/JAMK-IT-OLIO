using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTV16S4
{
    class Car
    { //property eli ominaisuus --> Auton nopeus.  Ominaisuudet ovat aina julkisia (public ....)
        //näinkin voi tehdä mutta vältä
        // public int Speed; <--- vältä

        public int Horsepower { get; set; } 
        //sisäinen muuttuja määrittelee maksiminopeuden joka oliolle voidaan asettaa.
        private const int maxSpeed = 200; //const tarkoittaa vakiota (luku ei muutu)
        private int speed;
        public int Speed
      
        {
            get //get - accessor palauttaa propertylle arvon
            {
                return speed;
            }
            //set accessorilla asetetaan propertyn arvoa
            set
            {
                if (value > maxSpeed)
                    speed = maxSpeed;
                else
                speed = value;
            }   
        }
        //constructors
        public Car()
        { }
        public Car (int horsepower, int speed)
        {
            Horsepower = horsepower;
            if (speed < maxSpeed)
                this.Speed = speed; //this. viittaa olioon itseensä
            else
                this.speed = maxSpeed;
           
        }


        //methods
        public void Accelerate(int additions)
        {
            //kiihdytetään autoa, muttei yli maksiminopeuden
            if (speed + additions < maxSpeed)
                speed = speed + additions;
            else
                speed = maxSpeed;
        }
    }
    
   
   
    class Program
    {
        static void TestMyCarClass()
        {
            //luodaan Car-olio, auto = uusi auto jolla nopeus 175.
            Car car = new Car();
            car.Speed = 175;
            //luodaan toinen pirssi
            Car car2 = new Car();
            car2.Horsepower = 300;
            car2.Speed = 250;
            //luodaan kolmas pikkufiiu
            Car fiat = new Car(55, 105);

            //Näytetään konsolilla
            Console.WriteLine("Autosi 1 nopeus on {0}", car.Speed);
            Console.WriteLine("Autosi 2 Nopeus on {0}", car2.Speed);
            //kiihdytetään kumpaakin autoa
            car.Accelerate(20);
            car2.Accelerate(20);
            fiat.Accelerate(20);
            Console.WriteLine("kiihdytettiin  20km/h");
            Console.WriteLine("Autosi 1 nopeus on {0}", car.Speed);
            Console.WriteLine("Autosi 2 Nopeus on {0}", car2.Speed);
            Console.WriteLine("Autosi fiat Nopeus on {0}", fiat.Speed);

        }
        static void Main(string[] args)
        {
            TestMyCarClass();
        }
    }
}
