using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HandsOnLinq
{
    class Demo5
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
            var res = list.Where(i => i.Desig == "Programmer"); //differed execution
            list.Add(new Employee() { Eid = 1, Ename = "Tanya", Salary = 12000, Desig = "Programmer" });
           
            foreach(var k in res)
            {
                Console.WriteLine(k.Ename);
            }
            List<Employee> res1 = list.Where(i => i.Desig == "Programmer").ToList();
            Employee[] res2 = list.Where(i => i.Desig == "Programmer").ToArray();
            Employee e = list.SingleOrDefault(i => i.Eid == 1); //throws exception when expression return multiple records
            Employee e1 = list.Single(i => i.Eid == 1); //throws exception when expression not return any record and expression return more than one records
            
            Console.WriteLine(res1.Count);
        }
    }
}
