using System;

namespace Lesson07HandsOn
{

    class Employee
    {
        string name;
        int salary;
        string hireDate;

        public Employee(string name, int salary, string hireDate)
        {
            this.name = name;
            this.salary = salary;
            this.hireDate = hireDate;
        }

        public virtual void getName()
        {
            Console.WriteLine("Employee Name: " + this.name);
        }

        public virtual void getSalary()
        {
            Console.WriteLine("Salary: " + this.salary);
        }

        public virtual void hiredDate()
        {
            Console.WriteLine("Hire Date: " + this.hireDate);
        }
    }

    class Engineer : Employee
    {
        string schoolAttended;

        public Engineer(string name, int salary, string hireDate, string schoolAttended) : base(name, salary, hireDate)
        {
            this.schoolAttended = schoolAttended;
        }
    }

    class SoftwareEngineer : Engineer
    {
        public SoftwareEngineer(string name, int salary, string hireDate, string schoolAttended) : base(name, salary, hireDate, schoolAttended)
        {}

        public override void getSalary()
        {
            Console.WriteLine("Salary: Sorry, this employee's salary is private.");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Engineer engineer1 = new Engineer("Rupert Scott", 42000, "11/22/12", "Arizona State University");

            engineer1.getName();
            engineer1.getSalary();
            engineer1.hiredDate();

            Console.WriteLine("-----------------");

            SoftwareEngineer softwareEngineer1 = new SoftwareEngineer("Shea Rovington", 78000, "03/27/18", "Tech School");

            softwareEngineer1.getName();
            softwareEngineer1.getSalary();
            softwareEngineer1.hiredDate();
        }
    }
}