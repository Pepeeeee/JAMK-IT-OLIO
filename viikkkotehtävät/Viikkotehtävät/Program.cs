using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Viikkotehtävät
{
    class Program
    {

        static void Main()
        {
            Console.WriteLine("Tereve tulemast, paina 1");
            string retval = Console.ReadLine();
            int valinta = int.Parse(retval);

            switch (valinta)
            {
                case 1:
                    tehtava1();
                    break;
                    //case 2:
                    //tehtava2();
                    // break;


            }
        }
        static void tehtava1()
        {
            Console.WriteLine("Kirjota luku 1,2 tai 3");
            string retval = Console.ReadLine(); // Retval palauttaa arvon 'return value'
            int luku = int.Parse(retval);

            if (luku == 1)
            {
                retval = "yksi";
                Console.WriteLine(retval);
            }
            else if (luku == 2)
            {
                retval = "kaksi";
                Console.WriteLine(retval);
            }
            else if (luku == 3)
            {
                retval = "kolome";
                Console.WriteLine(retval);
            }

            else
            {
                retval = "blah";
                Console.WriteLine(retval);
            }
        } //teht 1 lopppuu






    } //tän yläpuolelle tehtäviä
}
