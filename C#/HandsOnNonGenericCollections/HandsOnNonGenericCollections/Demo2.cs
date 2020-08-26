using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
namespace HandsOnNonGenericCollections
{
    class Employee
    {
        public int eid;
        public string ename;
        public DateTime joinDate;
        public double salary;
    }

    class Demo2
    {
        public static void GetEmployee(int id)
        {
            Employee e1 = new Employee();
            e1.eid = 100;
            e1.ename = "Rohan";
            e1.joinDate = DateTime.Parse("1.2.2000");
            e1.salary = 40000;
            Employee e2 = new Employee()
            {
                eid = 101,
                ename = "Karan",
                joinDate = DateTime.Parse("2.2.2010"),
                salary = 12000
            };
            Employee e3 = new Employee() { eid = 102, ename = "Jeson" };
            List<Employee> list = new List<Employee>() { e1, e2, e3 };
            bool flag = false;
            foreach (Employee item in list)
            {
                if (item.eid == id)
                {
                    flag = true;
                    Console.WriteLine("{0} {1} {2} {3}", item.eid, item.ename, item.joinDate, item.salary);
                    break;
                }
            }
            if (!flag)
                Console.WriteLine("Invalid Id");
        }
        public static void Main()
        {
            Employee e1 = new Employee();
            e1.eid = 100;
            e1.ename = "Rohan";
            e1.joinDate = DateTime.Parse("1.2.2000");
            e1.salary = 40000;
            Employee e2 = new Employee()
            {
                eid = 101,
                ename = "Karan",
                joinDate = DateTime.Parse("2.2.2010"),
                salary = 12000
            };
            Employee e3 = new Employee() { eid = 102, ename = "Jeson" };
            ArrayList ar = new ArrayList() { e1, e2, e3 };
            Employee e = (Employee)ar[0];
            //foreach(Employee item in ar)
            //{
            //    Console.WriteLine("{0} {1} {2} {3}", item.eid, item.ename, item.joinDate, item.salary);
            //}
            List<Employee> list = new List<Employee>() { e1, e2, e3 };
            e = list[1];
            //foreach (Employee item in list)
            //{
            //    Console.WriteLine("{0} {1} {2} {3}", item.eid, item.ename, item.joinDate, item.salary);
            //}
            GetEmployee(109);

        }
    }
}
