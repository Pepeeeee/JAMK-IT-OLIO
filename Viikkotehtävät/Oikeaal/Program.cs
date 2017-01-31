using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OikeaaOliota
{
  /* public class Vehicle
    {
        //Properties
        public string Nimi { get; set; }
        public string speed { get; set; }
        public string tyres { get; set; }

        //constructors
        public Vehicle()
        {
          
        }
        public Vehicle(string nimi) : base()
        {
            this.Nimi = Nimi;
        }
        
        //Methods

        static void Testiauto()
        {
            Vehicle MunVehicle = new Vehicle();

            MunVehicle.Nimi = "Porche";
            MunVehicle.speed = "100Mph";
            MunVehicle.tyres = "isot ja pyöreät";
            List<Vehicle> Autot = new List<Vehicle>();
            Autot.Add(MunVehicle);            
        }
  }*/

public class opiskelija
    {
        //properties
        public string Nimi { get; set; }
        public string väri { get;}
        public string lempiaine { get; set; }
        //constructors
        public opiskelija()
        {
            this.väri = Color.White;
        }

        public opiskelija(string nimi) : base ()
        {
            this.Nimi = nimi;
        }
        //methods
    }

    class opiskelijademo
    {
        static void main(string[] args)
        {
            TestaaOpiskelija();
        }

        static void TestaaOpiskelija()
        {
            opiskelija mina = new opiskelija();
            mina.Nimi = "petri";
            Color väri = mina.väri;

            opiskelija sina = new opiskelija("kata");
            List<opiskelija> Opiskelijat = new list<opiskelija>();
            Opiskelijat.Add(mina);
            Opiskelijat.Add(sina);

            Console.WriteLine("{0} ja {1} ollaan opiskelijoita", mina.Nimi, sina.Nimi);

        }
    }





}


