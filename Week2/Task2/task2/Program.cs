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
            string s = Console.ReadLine(); // lead out the string
            File.WriteAllText (@"C:\Users\Acer\Desktop\example\lab2_2in.txt", s); // write down it into file

            FileStream a = new FileStream(@"C:\Users\Acer\Desktop\example\lab2_2in.txt", FileMode.Open, FileAccess.Read);// to read all things
            StreamReader b = new StreamReader(a); // translate
            string[] st = b.ReadToEnd().Split(); // transfer all things
            b.Close();
            a.Close();

            FileStream a1 = new FileStream(@"C:\Users\Acer\Desktop\example\lab2_2out.txt", FileMode.Open, FileAccess.Write); // to write all things
            StreamWriter b1 = new StreamWriter(a1); // translate

            for (int i = 0; i < st.Length; i++) // for each index
            {
                int cnt = 0; // count prime numbers


                for (int j = 2; j <= Math.Sqrt (int.Parse(st[i])); j++) // Math formula for prime numbers
                {
                    if (int.Parse(st[i]) % j == 0) // find all dividers of number
                        cnt++;
                }
                if (cnt == 0 && int.Parse(st[i]) != 1)
                    b1.Write(st[i] + " "); // if the all conditions are performed, then lead out all to file
            }
            b1.Close();
            a1.Close();
            

        }
    }
}
