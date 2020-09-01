using System;
using System.Collections.Generic;
using System.Text;

namespace HandsClassProgramming
{
    class Employee
    {
        public int eId;
        public string eName;
        public double salary;
        //default constructor
        public Employee()
        {
            eId = 100;
            eName = "Rohan";
            salary = 12000;
        }
        //parameter constructor
        public Employee(int id,string name,double sal)
        {
            eId = id;
            eName = name;
            salary = sal;
        }
        public void Show()
        {
            Console.WriteLine("ID: {0}\n Name: {1} \n Salary: {2} \n", eId, eName, salary);
        }
    }

    class Demo1
    {
        public static void Main()
        {
            Employee e = new Employee();
            Employee e1 = new Employee();
            Employee e2 = new Employee(102,"John",12000);
            Employee e3 = new Employee(103, "Suren", 23000);
            //e.Show();
            //e1.Show();
            List<Employee> list = new List<Employee>() { e, e1, e2, e3 };
            foreach (Employee ob in list)
                Console.WriteLine("Id: {0} Name:{1}", ob.eId, ob.eName);
        }
    }
}
