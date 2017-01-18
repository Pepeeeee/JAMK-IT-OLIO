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
            Valikko1();
         }

        static void Valikko1()
        {
            Console.WriteLine("Tereve tulemast tehtävien pariin");
            Console.WriteLine("Paina joku numero 1-3(20): ");
            string retval = Console.ReadLine();
            int valinta = int.Parse(retval);
            Console.Clear();
            switch (valinta)
            {
                case 1:
                    tehtava1();
                    break;

                case 2:
                    tehtava2();
                    break;

                case 3:
                    tehtava3();
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
            
            Valikko1();
            
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

            else if (numero == 4 || numero == 5)
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
            Valikko1();






        }

        static void tehtava3()
        {
           
            ////Tee ohjelma, joka kysyy käyttäjältä kolme lukua ja tulostaa niiden summan ja keskiarvon.

            

            int[] array = new int[3];
            Console.WriteLine("Kerro mulle kolme lukua niin tulostan niiden summan ja keskiarvon:");
            for (int i = 0; i < 3; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            int pituus = array.Length;
            int summa = 0;
            int keskiarvo = 0;

        for (int i = 0; i < pituus; i++)
            {

            summa += array[i];

            }

                keskiarvo = summa / pituus;
            Console.WriteLine("summa: " + summa);
            Console.WriteLine("Keskiarvo: " + keskiarvo);
            Console.ReadLine();





            Valikko1();
        }
         

    }//tän yläpuolelle tehtäviä 1231231231231233122
}