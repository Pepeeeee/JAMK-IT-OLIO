using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;



namespace Random  

{

     public class Student

    {
        // Properties:
        public int Age { get; set; }
        public string ID { get; set; }
        public string Name { get; set; }
        // Methods:
        public void Eat()
        {
            Console.WriteLine("Omnom... ");
        }
        public void Sleep()
        {
            Console.WriteLine("Krooh... ");
        }
        public void WriteCode()
        {
            Console.WriteLine("No voihan nyt vihvilä sentään.");
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            // Luodaan opiskelijat:
            Student jeppe = new Student();
            jeppe.Age = 25;
            jeppe.Name = "Jeppe";
            jeppe.ID = "K1234";
            Student junnu = new Student();
            junnu.Age = 19;
            junnu.Name = "Junnu";
            junnu.ID = "K9934";
            Student kete = new Student();
            kete.Age = 21;
            kete.Name = "Kete";
            kete.ID = "K2222";
            Student lennu = new Student();
            lennu.Age = 24;
            lennu.Name = "Lennu";
            lennu.ID = "K4321";    
            Student heka = new Student();
            heka.Age = 30;
            heka.Name = "Heka";
            heka.ID = "K1334";
            // Lisätään ne taulukkoon:
            string[,] students = new string[5, 3]
            {
                { jeppe.Name, jeppe.ID, jeppe.Age.ToString()},
                { junnu.Name, junnu.ID, junnu.Age.ToString() },
                { kete.Name, kete.ID, kete.Age.ToString() },      
                { lennu.Name, lennu.ID, lennu.Age.ToString() },
                { heka.Name, heka.ID, heka.Age.ToString() }
            };
            // Tulostetaan teulukon paikat:
            for (int i = 0; i < 5; i++
            {
                Console.WriteLine("Opiskelija {0}: ", (i + 1));
                for (int j = 0; j < 3; j++)
               {
                    Console.WriteLine(students[i, j]);
                }
                Console.WriteLine();

            }

        }

    }

    

    //^ esmerkki

