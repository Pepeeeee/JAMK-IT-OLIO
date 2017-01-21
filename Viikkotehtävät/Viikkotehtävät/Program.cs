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
            Console.WriteLine("Tereve tulemast, paina 1-5(20)");
            string retval = Console.ReadLine();
            int valinta = int.Parse(retval);

            switch (valinta) //valikko helpottamaan selailua
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

                case 4:
                    tehtava4();
                    break;

                case 5:
                    tehtava5();
                    break;

                case 6:
                    tehtava6();
                    break;

                case 7:
                    tehtava7();
                    break;

                case 8:
                    tehtava8();
                    break;

                case 9:
                    Tehtava9();
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

        }

        static void tehtava3()
        {
            /// tee ohjelma joka kysyy 3 lukua joka plussaa ne ja kertoo keskiarvon 

            Console.WriteLine("anna Kolme lukua: ");
            float[] luku = new float[3];
            int i = 0;

            for (i = 0; i < 3; i++)
            {
                luku[i] = int.Parse(Console.ReadLine());
            }

            float sum1 = luku.Sum();

            float sum2 = luku.Sum() / 3;

            Console.WriteLine("summa: " + sum1);

            Console.WriteLine("keskiarvo: " + sum2);

        }
        static void tehtava4()
        {
            //tee ohjelma joka kysyy käyttäjältä iän

            Console.WriteLine("alaikärajamittari!! kerro ikäs");

            int ika = int.Parse(Console.ReadLine());
            string tulos;

            if (ika < 18) { tulos = "alaikainen"; }
            else if (ika >= 18 && ika <= 65) { tulos = "aikuinen"; }
            else { tulos = "Wanhus"; }

            Console.WriteLine("Olet : " + tulos);
        }

        static void tehtava5() {
            Console.WriteLine("anna sekunteja");

            int tunti = 0;
            int minuutti = 0;
            int sekunti = 0;
            int aika = int.Parse(Console.ReadLine());

            sekunti = aika % 60;
            minuutti = sekunti % 60;
            tunti = minuutti % 60;

            Console.WriteLine(tunti + " tuntia " + minuutti + " minuuttia " + sekunti + " sekuntia ");
                }

        static void tehtava6()
        {
            Console.WriteLine("Anna autolla kuljettu matka, miellellää ferrari");
            int matka = int.Parse(Console.ReadLine());
            Double kulutus = 0.0702 * matka;
            Double kulut = 1.595 * kulutus;

            Console.WriteLine("Kulunut polttoaine : " + kulutus + " Litraa " + "\nPolttoaineen kustannus :" + kulut + " Euroa");

        }

        static void tehtava7() //selvitetään onko vuotesi karkausvuosi
        {
            Console.WriteLine("Anna joku vuosi ");

            int vuosi = int.Parse(Console.ReadLine()); //vuosi = mitä tuli cmd:stä
            int eka = vuosi % 4;        //poistetaan vuodet jotka on jaollisia neljällä
            int toka = vuosi % 1000;    //poistetaan vuodet jaollisia 1000
            int kolomas = vuosi % 4000; //poistetaan vuodet jaolliset 4000

            bool tosi = true;
            if (toka == 0 && kolomas != 0)
            {
                tosi = false;
            }

            else if (eka == 0 || kolomas == 0)
            {
                tosi = true;
            }

            if (tosi)
            {
                Console.WriteLine("karkausvuosi");
            }
            else if (!tosi)
            {
                Console.WriteLine("Ei Karkausvuosi");
            }
        }

        static void tehtava8() //kysyy käyttäjältä 3 lukua ja tulostaa suurimman
        {
            Console.WriteLine("Anna 3 lukua");

            int[] luku = new int[3];
            int i = 0;
            int temp;
            for (i = 0; i < luku.Length; i++)
            {
                luku[i] = int.Parse(Console.ReadLine());
            }

            for (int g = i + 1; g < luku.Length; g++)
            {
                //verrataan g:tä ja i:tä ja korvataan i: suuremmalla luvulla
                if (luku[i] > luku[g])
                {
                    temp = luku[i];
                    luku[i] = luku[g];
                    luku[g] = temp;
                }
            }

            Console.WriteLine("\n" + luku[0]);

        }

         
            static void Tehtava9()
            { 

            //  Tee ohjelma, joka kysyy käyttäjältä lukuja, kunnes 
            //syöttää luvun +

           Console.WriteLine("Syota lukuja ja lopeta syotta painamalla 0"); 
            int[] luku = new int[1000]; 
            int summa = 0; 
            for (int i = 0; i<luku.Length;i++) 
                    { 

                 luku[i] = int.Parse(Console.ReadLine()); 
                 summa += luku[i]; 

                 if (luku[i] == 0) 

                    { 
                     Console.WriteLine("\nSumma: " + summa); 
                         break; 
                     }
            } 
      }


    } //tän yläpuolelle tehtäviä 1231231231231233122
    } //viimeinen sulku
