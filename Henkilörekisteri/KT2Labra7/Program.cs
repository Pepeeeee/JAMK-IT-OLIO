using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KT2Labra7
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string DocPath = @"c:\Temp\names.txt";

                if (!File.Exists(DocPath))
                {

                    using (StreamWriter sw = File.CreateText(DocPath))
                    {
                        sw.WriteLine("Aappo");
                        sw.WriteLine("Benkku");
                        sw.WriteLine("Jaakko");
                        sw.WriteLine("Wille");
                        sw.WriteLine("Aappo");
                        sw.WriteLine("Benkku");
                        sw.WriteLine("Jaakko");
                        sw.WriteLine("Wille");
                        sw.WriteLine("Sebastian");
                        sw.WriteLine("Aappo");
                        sw.WriteLine("Cecilia");
                        sw.WriteLine("Netta");
                        sw.WriteLine("Jaakko");
                        sw.WriteLine("Wille");
                        sw.WriteLine("Matias");
                        sw.WriteLine("Netta");
                        sw.WriteLine("Cecilia");
                        sw.WriteLine("Otto");
                        sw.WriteLine("Aappo");
                        sw.WriteLine("Wille");
                    }
                }

                try
                {
                    string[] lines = System.IO.File.ReadAllLines(DocPath);
                    Dictionary<string, int> names = new Dictionary<string, int>();

                    foreach (string s in lines)
                    {
                        if (names.ContainsKey(s))
                        {
                            names[s]++;
                        }
                        else
                        {
                            names[s] = 1;
                        }
                    }

                    Console.WriteLine("Löytyi {0} riviä ja {1} nimeä", lines.Length, names.Count);
                    foreach (var n in names)
                    {
                        Console.WriteLine("Nimi {0} esiintyi {1} kertaa.", n.Key, n.Value);
                    }
                }
                catch (System.IO.FileNotFoundException)
                {
                    Console.WriteLine("File not found (FileNotFoundException)");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
