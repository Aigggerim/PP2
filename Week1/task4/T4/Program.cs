using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); // enters a line by converting a stirng to integer
            char[,] a = new char[n, n]; // create 2D array
            for (int i = 0; i < n; i++) // for each index i
            {
                for (int j = 0; j <= i; j++) //for each index j
                {
                    Console.Write("[*]"); // shows [*]

                }
                Console.WriteLine();// next line
            }
        }
    }
}
