using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        public static bool Pal(string s)
        {
            for (int i = 1, j = s.Length - 1; i < j; i++, j--)
            {

                if (s[i] != s[j])
                    return false;
            }
            return true;
        }
            static void Main(string[] args)
        {
            string text = File.ReadAllText(@"C:\Users\Acer\Desktop\lab2_1.txt");
            if (Pal(lab2_1.txt))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
                Console.ReadKey();
            }
    }
}
