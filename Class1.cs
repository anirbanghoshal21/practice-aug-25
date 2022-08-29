using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Directory_Q3
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\Public\Anirban\Directory Q3\Directory Q3\bin\Debug\Results";
            string[] fnames = Directory.GetFiles(path);
            foreach (var item in fnames)
            {
                Console.WriteLine(item);
            }
            string[] dirs = Directory.GetDirectories(path);
            foreach (var item in dirs)
            {


                Console.WriteLine(item);
                string[] fnames = Directory.GetFiles(item);
                //foreach (var item1 in fnames)
                {
                    Console.WriteLine("Results 17-18");
                    Console.WriteLine(item);
                }
                Console.WriteLine("---------");
                Console.ReadLine();
            }
        }
    }
}
