using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace HandsOnLinq
{
    class Student
    {
        public int Sid { get; set; }
        public string Sname { get; set; }
    }
    class Course
        {
        public int Sid { get; set; }
        public string Cname { get; set; }
        }
    class Demo4
    {
        static void Main()
        {
            List<Student> list1 = new List<Student>()
            {
                new Student(){Sid=1,Sname="Rohan"},
                  new Student(){Sid=2,Sname="Karan"},
                    new Student(){Sid=3,Sname="Jeson"},
            };
            List<Course> list2 = new List<Course>()
            {
                new Course(){Sid=1,Cname="Angular"},
                  new Course(){Sid=2,Cname="Angular"},
                    new Course(){Sid=3,Cname="Angular"},
                      new Course(){Sid=1,Cname="React"},
                        new Course(){Sid=2,Cname="React"},
            };
            var r = from l1 in list1
                    join l2 in list2
                    on l1.Sid equals l2.Sid
                    select new { Sid = l1.Sid, Sname = l1.Sname, Cname = l2.Cname };
            //group data
            var r1 = from l1 in list1
                     join l2 in list2
                     on l1.Sid equals l2.Sid
                     group new { Sname = l1.Sname, Cname = l2.Cname }
                     by l2.Cname;
            foreach (var k in r1)
            {
                Console.WriteLine("Student Enrolled in {0} ", k.Key);
                foreach (var j in k)
                {
                    Console.WriteLine("{0}", j.Sname);
                }
            }


        }
    }
}
