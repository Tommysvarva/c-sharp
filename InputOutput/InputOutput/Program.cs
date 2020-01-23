using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace InputOutput
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hei, hva heter du ?");
            //var name = Console.ReadLine();
            //Console.WriteLine("Hei" + name);

            var text = File.ReadAllText("tekst.txt");
            Console.WriteLine(text);
        }
    }
}
