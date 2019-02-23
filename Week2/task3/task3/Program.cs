using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace task3
{
    class Program {
        public static void Lev(int l) // create function which will read all tabulation and lead out it
        {
            for (int i = 0; i < l; i++) // for each index
            {
                Console.Write(" ");
            }


        }
        public  static void T(DirectoryInfo dir,int lvel)
        {
           foreach(FileInfo fi in dir.GetFiles())
            {
                Lev(lvel);
                Console.WriteLine(fi.Name);
            }
           foreach(DirectoryInfo di in dir.GetDirectories())
            {
                Lev(lvel);
                Console.WriteLine(di.Name);
                T(di, lvel + 1);
            }
        }
        static void Main(string[] args)
        {
            DirectoryInfo d = new DirectoryInfo(@"C:\Users\Acer\Desktop\Progr2"); // open file
            T(d, 0); // will lead out tree with 2 dimensions
        }
    }
}