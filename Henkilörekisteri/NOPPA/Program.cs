using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace noppa
{
    class Program
    {
        public static int Heitto()
        {
            Random r = new Random();
            Thread.Sleep(32);
            return r.Next(1, 7);
        }

        static void Main(string[] args)
        {
            List<int> randomm = new List<int>();
            Console.Write("Monta ja mitä\n");
            int lenght = int.Parse(Console.ReadLine());
            for (int i = 0; i < lenght; i++)
            {
                Console.WriteLine(Heitto());
                randomm.Add(Heitto());
            }
            Console.WriteLine("\n\nDice was rolled {0} times and the average was {1}" , lenght , randomm.Average());

        }

        
    }
}