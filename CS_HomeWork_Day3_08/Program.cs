using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_HomeWork_Day3_08
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("Alex", "Ivanov", "Vasilevych", "VPO-180", 21);
            student.AboutStudent();
            System.Console.ReadKey();
        }
    }
}
