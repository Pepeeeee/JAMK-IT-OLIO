using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    public class Vehicle
    {
        //constants and variables (luokan sisäisiä) ((rajoittaa luokkaa))
        private const int maxTyres = 4;
        private int countTyres = 0;
        //properties 
        public string Brand { get; set; }
        public string Model { get; set; } 
        public Tyre[] Tyres { get; } //taulukon koko on kiinteä  JOTAIN[] <-- Taulukko
     //lista on  dynaaminen
     public List<Tyre> Renkaat { get; }  //ignoraa
       

        //constructors   ON AINA LUOKAN NIMINEN
        public Vehicle()
        {
            Tyres = new Tyre[maxTyres];
            Renkaat = new List<Tyre>;

        }
        //methods
        public AddTyreToList(Tyre tyre)   //ignoraa :d
        {
            Renkaat.Add(tyre);
        }
        public void AddTyre(Tyre tyre)  //public, näkyy kaikille. Void --> ei palauta mitään, Addtyre -> methodin nimi. Tyre tyre¨--> parametri
        {
            if (countTyres < maxTyres)
            {
                Tyres[countTyres] = tyre;
                countTyres++;
                Console.WriteLine("Rengas {0} lisätty ajoneuvoon {1}", tyre.ToString(), this.Brand);
            }
           else
            {
                Console.WriteLine("Ei sovi enää uusia renkaita, sorry");
            }
            
        }
        public override string ToString()
        {
            string retval = "Ajoneuvo valmistaja: " + Brand + " malli: " + Model + "\nrenkaat:";
            foreach (Tyre tyre in Tyres)
            {
                if (tyre !=null)
                {
                    retval += "\n" + tyre.ToString();
                }
            }
            //ja listataan listan alkiot myös
            foreach (Tyre tyre in Renkaat) 
            {
                retval += "\n" + tyre.ToString();       //VAPAAEHTOINEN LISTAUSDUUNI, SEKOITTAA VAIN IGNORAA
            }
            return retval;
        }
    }

    public class Tyre
    {
        public string Branch { get; set; }
        public string Size { get; set; }
        public override string ToString()
        {
            return "valmistaja: " + Branch + " Koko: " + Size;
            //tai return String.Format("valmistaja on {0} koko on {1}", Branch, Size);
        }
    }
}
