using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {

        static bool Prime(int n) //it will check number is prime or not
        {
            if (n == 0 || n == 1) // if number is equal to 0 and 1, it is not prime. So function will continue.
            {
                return false;
            }
            for (int i = 2; i <= Math.Sqrt(n); i++) // Here we use rule of primes.
            {

                if (n % i == 0) // if n divides to i, the function will continue.
                {
                    return false;
                }
            }
            return true; // in other case it is prime
        }

        static void Main(string[] args)
        {
            int cnt = 0; // number of primes
            string s = Console.ReadLine();// string
            string[] s1 = Console.ReadLine().Split();// enters an array by splitting spaces from the line

            int n = int.Parse(s); // enters line by converting string to integer

            for (int i = 0; i < n; i++) // for every index
            {
                if (Prime(int.Parse(s1[i]))) // if it is true
                    cnt++; // counts number of primes
            }
            Console.WriteLine(cnt); // shows number of primes
            for (int i = 0; i < n; i++) // for each index
            {
                if (Prime(int.Parse(s1[i]))) // if function is true
                    Console.Write(s1[i] + " "); // shows prime numbers
            }
        }
    }
}
