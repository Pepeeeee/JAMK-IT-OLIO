using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kotitehtäviä
{
    class Rengas
    {

        //properteja
        public string Valmistaja { get; set; }
        public string Malli { get; set; }
        public string rengaskoko { get; set; }

        public override string ToString()
        {
            return "Valmistaja: " + Valmistaja + " Malli:" + Malli + " rengas koko:" + rengaskoko;

        }
        //constructoreja

        //methodeja
    }
    class Auto
    {
        public string Merkki { get; set; }
        public string Malli { get; set; }
        private const int maxRenkaat = 4;
        private int lkmRenkaat = 0;
        public List<Rengas> Renkaat { get; }

        public Auto()
        {
            Renkaat = new List<Rengas>();
        }



        public void LisaaRengas(Rengas rengas)
        {

            if (lkmRenkaat < maxRenkaat)
            {
                Renkaat.Add(rengas);
                lkmRenkaat++;
                Console.WriteLine("Rengas {0} lisätty ajoneuvoon {1}", rengas.Malli, Merkki);
            }
            else
            {
                Console.WriteLine("Autossasi on jo 4 Rengasta");
            }

        }
        public override string ToString()
        {
            string s = "Autossasi: " + " Malli :" + Malli + "\nrenkaat:";
            foreach (Rengas r in Renkaat)
            {
                if (r != null) s += "\n-" + r.ToString();
            }
            return s;
        }


        static void Main(string[] args)
        {
            Kasataan_auto();
        }

        static void Kasataan_auto()
        {
            Rengas tyre1 = new Rengas { Valmistaja = "Suomi,", Malli = "Pyöreä", rengaskoko = "20tuumaiset" };
            //tehdään pyörille auto :)
            Auto datsuni = new Auto { Merkki = "Datsun", Malli = "1" };
            Console.WriteLine("Uusi auto luotu {0} {1}", datsuni.Merkki, datsuni.Malli);
            datsuni.LisaaRengas(tyre1);
            datsuni.LisaaRengas(tyre1);
            datsuni.LisaaRengas(tyre1);
            datsuni.LisaaRengas(tyre1);

            
        }
    }
}
