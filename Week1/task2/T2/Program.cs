using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2
{
    class Program
    {
        class Student
        {
            string name;
            int id, year;
            public Student(string name, int id)
            {
            }
                public String aname()
                {
                    return name;
                }
                public int anid()
                {
                    return id;
                }
                public void ayear (int year)
                {
                    ++year;
                }
            }
        
        static void Main(string[] args)
        {
        }
    }
}
