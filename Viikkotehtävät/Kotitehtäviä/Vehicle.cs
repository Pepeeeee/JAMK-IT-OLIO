using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kotitehtäviä
{
    class Vehicle
    {
        public string Merkki { get; set; }       //asetetaan ominaisuuksia
        public string Malli { get; set; }
        private const int MaxTyres = 4;         //classin sisäinen sääntö
        private int TyresCount = 0;
        public Tyre[] Tyres { get; }     //tehdään lista 'tyres'

        public Vehicle()
        {
            Tyres = new Tyre[MaxTyres];
        }

        public void AddTyre(Tyre tyre)
        {
            if (TyresCount < MaxTyres)
            {
                Tyres[TyresCount] = tyre;
                TyresCount++;
                Console.WriteLine("Rengas {0} laitettu autoosi {1}", tyre.Merkki, Merkki);
            }
            else
            {
                Console.WriteLine("On jo 4 rengasta!");
            }
        }

        public override string ToString()
        {
            string s = "Autosi nimi: " + Merkki + " Malli:" + Malli + "\nrenkaat:";
            foreach (Tyre tyre in Tyres)
            {
                if (tyre != null) s += "\n-" + tyre.ToString();
            }
            return s;
        }
    }
}
