using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Viikkotehtavat
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Katteleppasiitä kotitehtäviä");
            Tehtava1();
        }
        static void Tehtava1()
        {
            //Tee ohjelma, joka tulostaa käyttäjän antamaa lukua (1, 2 tai 3) 
            //vastaavan luvun sanana (yksi, kaksi tai kolme). Jos käyttäjä syöttää 
            //jonkin muun luvun, tulee näytölle tulostaa teksti: "jokumuu luku".
            Console.WriteLine("Anna 1, 2 tai 3 ja tulostan sen tekstinä");
            string retval = Console.ReadLine();
                     //retval --> return value!
            int luku = int.Parse(retval);
            //parse = voi stringejä ''parsia'' luvuiksi.
            if (luku == 1)
            {
                retval = "kirjoitit luvun yksi";
                // tulostus käyttäjälle
                Console.WriteLine(retval);
            }
            else if (luku == 2) ;
            {
                retval = "kirjoitit luvun kaksi";
                Console.WriteLine(retval);
         
            }
            else if (luku == 3) ;
            {
                retval = "kirjoitit luvun kolme";
                Console.WriteLine(retval);
            }


        }
    }
}
