using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Filess
{
    class Program
    {
        static void Main(string[] args)
        {
            //StreamWriter writer;
            //writer = new StreamWriter("test");
            //writer.WriteLine("Hello Friend! :)");
            //writer.Close();

            //StreamReader reader = new StreamReader("test");
            //string line = reader.ReadLine();
            //Console.WriteLine(line);
            //reader.Close();

            StreamReader read = new StreamReader("test");
            while (read.EndOfStream == false)
            {
                string lines = read.ReadLine();
                Console.WriteLine(lines);
            }
            read.Close();
        }
    }
}
