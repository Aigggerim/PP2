using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {

        static bool Prime(int n)
        {
            if (n == 0 || n == 1)
            {
                return false;
            }
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {

                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        static void Main(string[] args)
        {
            int cnt = 0;
            string s = Console.ReadLine();
            string[] s1 = Console.ReadLine().Split();

            int n = int.Parse(s);

            for (int i = 0; i < n; i++)
            {
                if (Prime(int.Parse(s1[i]))) cnt++;
            }
            Console.WriteLine(cnt);
            for (int i = 0; i < n; i++)
            {
                if (Prime(int.Parse(s1[i]))) Console.Write(s1[i] + " "); // shows how many primes there
            }
        }
    }
}
