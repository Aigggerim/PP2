using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Student //creating the class 
    {
        public string name;//create name
        public string id;//create id
        public int year;//create year

        public Student(string name, string id)//constructor which takes name and id
        {
            this.name = name;//equating variables of class to the variables of constructor
            this.id = id;
        }

        public void Inc()//method which increments the year of study and prints name, id and year
        {
            year++;
            Console.WriteLine("Student: {0}; ID: {1}; Increased Year: {2}", name, id, year);//prints values
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student Aigerim = new Student("Abdulla Aigerim", "18BD110942");//creating newrs
            Aigerim.year = 1;//giving value 
            Aigerim.Inc();//calling a method 
            Console.ReadKey();//closing console by pressing a key
        }
    }
}