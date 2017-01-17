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
            Console.WriteLine("Tereve tulemast, paina 1 tai 2");
            string retval = Console.ReadLine();
            int valinta = int.Parse(retval);

            switch (valinta)
            {
                case 1:
                    tehtava1();
                    break;

                case 2:
                    tehtava2();
                    break;


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

        static void tehtava2()
        {
            Console.WriteLine("Paljonkas sait poika pisteitä kokeesta?");
            string retval = Console.ReadLine(); // Retval palauttaa arvon 'return value'
            int numero = int.Parse(retval);

            if (numero == 0 || numero == 1)
            {
                retval = "numerosi on silti 0 LUUSERI";
                Console.WriteLine(retval);
            }

            else if (numero == 2 || numero == 3)
            {
                retval = "numerosi on silti vain 1 LUUSERI";
                Console.WriteLine(retval);
            }

            else if (numero == 4 || numero ==5)
            {
                retval = "numerosi on silti vain 2 LUUSERI";
                Console.WriteLine(retval);
            }
            else if (numero == 6 || numero == 7)
            {
                retval = "numerosi on silti vain 3 LUUSERI";
                Console.WriteLine(retval);
            }
            else if (numero == 8 || numero == 9)
            {
                retval = "numerosi alkaa olla jo hyvä mutta silti vain 4 LUUSERI";
                Console.WriteLine(retval);
            }
            else if (numero == 10 || numero == 11 || numero == 12)
            {
                retval = "OHO poikahan pisti. numero: 5";
                Console.WriteLine(retval);
            }







        } //tän yläpuolelle tehtäviä
    }
}