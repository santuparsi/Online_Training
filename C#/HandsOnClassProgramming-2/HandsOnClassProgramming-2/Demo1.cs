using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace HandsOnClassProgramming_2
{
    class Employee
    {
        public int eId;
        public string eName;
        public double salary;
        public static string companyName;//static variable
        public const double bonous=1000;
        public  void Details() //non static method
        {
            Console.WriteLine("ID: " + eId);
            Console.WriteLine("Name: " + eName);
            Console.WriteLine("Salary: " + salary);
            Console.WriteLine("Bonous: " + bonous);
            Console.WriteLine("Company Name: " + companyName);
        }
        //public static void f() { } // static method
    }

    class Demo1
    {
        static void Main()
        {
            //assign static values
            Employee.companyName = "ABC";
           // Employee.bonous = 1000;
            Employee e1 = new Employee() { eId=1,eName="Karan",salary=10000};
            Employee e2 = new Employee() { eId = 2, eName = "Karan", salary = 12000 };
            Employee e3 = new Employee() { eId = 3, eName = "Jeson", salary = 10000 };
            Employee e4 = new Employee() { eId = 4, eName = "Suren", salary = 12000 };
           
            List<Employee> list = new List<Employee>() { e1, e2, e3, e4};
            foreach(Employee e in list)
            {
                e.Details();
                Console.WriteLine("---------------------------------");
            }
            // Employee.bonous = 2000;
            Employee.companyName = "XYZ";
            Employee e5 = new Employee() { eId = 5, eName = "Monita", salary = 10000 };
            Employee e6 = new Employee() { eId = 6, eName = "Charan", salary = 12000 };
            Employee e7 = new Employee() { eId = 7, eName = "Krishna", salary = 10000 };
            Employee e8 = new Employee() { eId = 8, eName = "Ram", salary = 12000 };
            List<Employee> list1 = new List<Employee>() { e5, e6, e7, e8 };
            foreach (Employee e in list1)
            {
                e.Details();
                Console.WriteLine("---------------------------------");
            }

        }
    }
}
