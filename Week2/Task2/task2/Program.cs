using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            File.WriteAllText(@"C:\Users\Acer\Desktop\example\lab2_2in.txt", s);

            FileStream a = new FileStream(@"C:\Users\Acer\Desktop\example\lab2_2in.txt", FileMode.Open, FileAccess.Read);
            StreamReader b = new StreamReader(a);
            string[] st = b.ReadToEnd().Split();
            b.Close();
            a.Close();

            FileStream a1 = new FileStream(@"C:\Users\Acer\Desktop\example\lab2_2out.txt", FileMode.Open, FileAccess.Write);
            StreamWriter b1 = new StreamWriter(a1);

            for (int i=0; i<st.Length; i++)
            {
                int cnt = 0;


                for (int j=2; j<=Math.Sqrt(int.Parse(st[i])); j++)
                {
                    if (int.Parse(st[i]) % j == 0)
                        cnt++;
                }
                if (cnt == 0 && int.Parse(st[i]) != 1)
                    b1.Write(st[i] + " ");
            }
            b1.Close();
            a1.Close();
            

        }
    }
}
