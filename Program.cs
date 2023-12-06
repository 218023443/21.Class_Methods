using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21.Class_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student(70, "John", 15);
            Student student2 = new Student(40, "Tim", 10);

            Console.WriteLine("Please check whether "+student1.name +" is obese or not? "+student1.IsObese());
            Console.WriteLine("Please check whether " + student2.name + " is obese or not? "+student2.IsObese());
            Console.ReadLine();
        }
    }
}
