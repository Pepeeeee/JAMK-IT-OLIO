using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace L7T3
{
    class Program
    {
        static void Main(string[] args)
        {
            string IntegersPath = @"c:\Temp\T3Integers.txt";
            string DoublesPath = @"c:\Temp\T3Doubles.txt";

            do
            {
                Console.Write("Give a double or integer: ");
                string retval = Console.ReadLine();

                try
                {

                    int integer = int.Parse(retval);

                    if (!File.Exists(IntegersPath))
                    {
                        using (StreamWriter sw = File.CreateText(IntegersPath))
                        {
                            sw.WriteLine(integer);
                        }
                    }

                    using (StreamWriter sw = File.AppendText(IntegersPath))
                    {
                        sw.WriteLine(integer);
                    }
                }
                catch
                {
                    try
                    {
                        double dbl = double.Parse(retval);

                        if (!File.Exists(DoublesPath))
                        {
                            using (StreamWriter sw = File.CreateText(DoublesPath))
                            {
                                sw.WriteLine("{0:0.00}", dbl);
                            }
                        }

                        using (StreamWriter sw = File.AppendText(DoublesPath))
                        {
                            sw.WriteLine("{0:0.00}", dbl);
                        }
                    }

                    catch
                    {
                        Console.WriteLine("Contents of T3Integers.txt:");

                        try
                        {
                            string[] lines = System.IO.File.ReadAllLines(IntegersPath);
                            foreach (string line in lines)
                            {
                                Console.WriteLine(line);
                            }
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("error occured while reading file T3Integers.txt");
                        }

                        Console.WriteLine("Contents of T3Doubles:");

                        try
                        {
                            string[] lines = System.IO.File.ReadAllLines(DoublesPath);
                            foreach (string line in lines)
                            {
                                Console.WriteLine(line);
                            }
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Error occured while reading T3Doubles.txt");
                        }

                        break;
                    }
                }
            } while (1 == 1);
        }
    }
}