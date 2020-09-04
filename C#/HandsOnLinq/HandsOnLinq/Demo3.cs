using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace HandsOnLinq
{
    class Employee
    {
        public int Eid { get; set; }
        public string Ename { get; set; }
        public double Salary { get; set; }
        public string Desig { get; set; }
    }

    class Demo3
    {
        static void Main()
        {
            List<Employee> list = new List<Employee>()
            {
                new Employee(){Eid=1,Ename="Rohan",Salary=12000,Desig="Programmer"},
                 new Employee(){Eid=2,Ename="Jeson",Salary=52000,Desig="TeamLeader"},
                  new Employee(){Eid=3,Ename="Krishna",Salary=12000,Desig="Programmer"},
                   new Employee(){Eid=4,Ename="Rama",Salary=12000,Desig="Programmer"},
                    new Employee(){Eid=5,Ename="Rajan",Salary=42000,Desig="TeamLeader"},
                     new Employee(){Eid=6,Ename="Monica",Salary=12000,Desig="Programmer"},
                      new Employee(){Eid=7,Ename="Divya",Salary=42000,Desig="TeamLeader"},
                       new Employee(){Eid=8,Ename="Manish",Salary=12000,Desig="Programmer"},
                        new Employee(){Eid=9,Ename="Mohan",Salary=12000,Desig="Programmer"},
                         new Employee(){Eid=10,Ename="Sachin",Salary=120000,Desig="Project Manager"},
                          new Employee(){Eid=11,Ename="Rohith",Salary=12000,Desig="Programmer"},
            };
            //fetch all employees
            var res = from i in list select i;
            //fetch all employee sorted by ename
            var res1 = from i in list orderby i.Ename select i;
            //fetch employees who are working as programmer
            var res2 = from i in list where i.Desig == "Programmer" select i;
            //fetch employees working as teamleaders and salary>50000
            var res3 = from i in list where i.Desig == "TeamLeader" && i.Salary > 50000 select i;
            //fetch only Eid
            var res4 = from i in list select i.Eid;
            //fetech Eid,Ename
            var res5 = from i in list select new { i.Eid, i.Ename };
            foreach (var i in res5)
                Console.WriteLine("{0} {1} ", i.Eid, i.Ename);
            var res6 = from i in list
                       group i by i.Desig;
            foreach(var i in res6)
            {
                Console.WriteLine("Employees working as {0}: ", i.Key); //i.Key return Desig value
                foreach(var k in i)
                {
                    Console.WriteLine(k.Ename);
                }
            }
        }
    }
}
