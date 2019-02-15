using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadKey(); // button to create file
            string Fn = "lab2_4.txt"; // create name of file
            FileStream cr = File.Create(@"C:\Users\Acer\Desktop\example\" + Fn); // create file
            cr.Close(); // close way to file

            Console.ReadKey(); // checking if there first file

            Directory.CreateDirectory(@"C:\Users\Acer\Desktop\example\path2");// create directory to a new file
            File.Copy(@"C:\Users\Acer\Desktop\example\" + Fn, @"C:\Users\Acer\Desktop\example\path2\"+Fn, true); // copy this file, if ths file there exists, then "true" overwrite it. If it is false there wil be error
            File.Delete(@"C:\Users\Acer\Desktop\example\" + Fn); // delete first file
        }
    }
}
