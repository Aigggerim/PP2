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
            string s = Console.ReadLine();
            File.WriteAllText(@"C:\Users\Acer\Desktop\example\lab2_1.txt", s);
            FileStream a = new FileStream(@"C:\Users\Acer\Desktop\example\lab2_1.txt", FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader b = new StreamReader(a);
            string st = b.ReadLine();
            b.Close();
            a.Close();
            int cnt = 0;
            for (int i = 0, j = st.Length - 1; i < st.Length && j >= 0; i++, j--)
            {
                if (st[i] == st[j])
                    cnt++;
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
