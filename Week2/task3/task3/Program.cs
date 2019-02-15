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
        public static void Way(DirectoryInfo d, int l) {
            foreach (FileInfo f in d.GetFiles())   // if it is element of directory lead out it
            {
                Lev(l);
                Console.WriteLine(f.Name);

            
        }
            foreach (DirectoryInfo di in d.GetDirectories())
            {
                Lev(l);
                Console.WriteLine(di.Name); // write name 
                Way(di, l + 1);
          
            }
        }
        static void Main(string[] args)
        {
            DirectoryInfo d = new DirectoryInfo(@"C:\Users\Acer\Desktop\Progr2"); // open file
            Way(d, 0); // will lead out tree with 2 dimensions
        }
    }
}