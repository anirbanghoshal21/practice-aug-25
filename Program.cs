using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Directory_Q3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\Public\Anirban";
            Console.WriteLine("Enter the file name");
            string fname = Console.ReadLine();
            File.Create(path+fname);
            Console.WriteLine("file created successfully...");

            Directory.CreateDirectory("Results");

           

            Console.ReadLine();
        }
    }
}
