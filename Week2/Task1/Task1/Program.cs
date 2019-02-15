using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine(); // lead out string
            File.WriteAllText (@"C:\Users\Acer\Desktop\example\lab2_1.txt", s); // write down it to file

            FileStream a = new FileStream(@"C:\Users\Acer\Desktop\example\lab2_1.txt", FileMode.OpenOrCreate, FileAccess.Read); //  to read all things in this file
            StreamReader b = new StreamReader(a); // translate
            string st = b.ReadLine(); // read from file
            b.Close();
            a.Close();

            int cnt = 0; // will count letters
            for (int i = 0, j = st.Length - 1; i < st.Length && j >= 0; i++, j--) // for each index i from beginning, j from the end
            {
                if (st[i] == st[j]) // if they are same or equal
                    cnt++; // count or add
            }

                    if (cnt==st.Length) 
                {
                    Console.Write("Yes");
                }
                else
                {
                    Console.Write("No");

                }
            }
        }
    }
