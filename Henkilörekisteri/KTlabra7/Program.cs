using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KTlabra7
{
    class program
    {

    
            static void Main(string[] args)
        {
                string DocPath = "exdee.txt";
                string retval;

                System.IO.StreamWriter outputFile = new System.IO.StreamWriter(DocPath);

                do
                {
                    Console.Write("Input for txt file: ");
                    retval = Console.ReadLine();

                    outputFile.WriteLine(retval);
                } while (retval != "end");

                outputFile.Close();

                try
                {
                    string text = System.IO.File.ReadAllText(DocPath);
                    Console.WriteLine("Contents of your txt-file:");
                    Console.WriteLine(text);
                }
                catch (System.IO.FileNotFoundException)
                {
                    Console.WriteLine("File not found (FileNotFoundException)");
                }
            }
        }

}