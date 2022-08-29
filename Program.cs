using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace filestream_Q1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //File.Create("Basics.txt");

            FileStream fs = new FileStream("Basics.txt", FileMode.Truncate, FileAccess.Write);
            Console.WriteLine("Truncated");

            
            Console.ReadLine();
        }
    }
}
