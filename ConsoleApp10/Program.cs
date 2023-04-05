using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
   public class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee("Mike", 980.7, 22);
            emp.CalculateSalary();
            Console.WriteLine(emp.EmployeeDetails());

            Manager man = new Manager("Saul", 786.9, 32);
            man.CalculateSalary();
            Console.WriteLine(man.DisplayManagerDetails());

            SalePerson sp = new SalePerson("Gus", 8765.8, 45);
            sp.CalculateSalary();
            Console.WriteLine(sp.DisplaySalePersonDetails());
        }
    }
}
