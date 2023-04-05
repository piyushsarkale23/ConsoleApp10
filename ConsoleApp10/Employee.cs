using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    public class Employee
    {
        //class variables// data members
     
        protected int id;
        protected string name;
        protected int age;
        protected double basic, hra, da, ta, gross, pf;
        private static int count;
        //constructor
        public Employee(string name, double basic,int age)
        {
            count++;
            id = count;
            this.name = name;
            this.basic = basic;
            this.age = age;
        }
        //method
        public virtual void CalculateSalary()
        {
            hra = basic * 0.40;
            da = basic * 0.20;
            ta = basic * 0.10;
            pf = basic * 0.12;
            gross = (basic + hra + da + ta) - pf;
        }
        //method
        public string EmployeeDetails()
        {
            return $"Id ={id} , Name ={name}, Basic Salary ={basic}, Gross of Employee ={gross}";
        }
    }

    public class Manager : Employee
    {
        private double food, ma;
        // base keyword will call the base class constructor
        public Manager(string name, double basic,int age) : base(name, basic,age)
        {

        }
        public override void CalculateSalary()
        {
            hra = basic * 0.40;
            da = basic * 0.20;
            ta = basic * 0.10;
            pf = basic * 0.12;
            food = basic * 0.05;
            ma = basic * 0.12;
            gross = (basic + hra + da + ta + food) - (pf + ma);

        }
        public string DisplayManagerDetails()
        {
            return $"Id ={id} , Name ={name}, Basic Salary ={basic}, Gross of Manager ={gross}";
        }
    }

       public class SalePerson :Employee
    {
        private double food, ma;
        private double Commission ;
        private int bonus = 1000;
        // base keyword will call the base class constructor
        public SalePerson(string name, double basic,int age) : base(name, basic,age)
        {

        }
        public new void CalculateSalary()
        {
            hra = basic * 0.40;
            da = basic * 0.20;
            ta = basic * 0.10;
            pf = basic * 0.12;
            food = basic * 0.05;
            ma = basic * 0.12;
            Commission = basic * 0.3;
            basic = basic + bonus;
            gross = (basic + hra + da + ta + food + Commission + bonus) - (pf + ma);

        }
        public string DisplaySalePersonDetails()
        {
            return $"Id ={id} , Name ={name}, Basic Salary ={basic}, Bonus is {bonus}, Commission is {Commission}, Gross of Manager ={gross}";
        }

    }

}

