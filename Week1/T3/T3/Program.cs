using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); // enters line by converting string to integer
            string[] a = Console.ReadLine().Split(' '); // enters an array by splitteing spaces from the line
            for (int i = 0; i < n; i++) // for each index
            {
                Console.Write(a[i] + ' ' + a[i] + ' '); // shows every number twice
            }
        }
    }
}
