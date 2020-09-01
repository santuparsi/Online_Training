using System;
using System.Collections.Generic;
using System.Text;

namespace HandsClassProgramming
{
    class Calculate
        {
        public void Add(int a,int b)
        {
            Console.WriteLine("Add: " + (a + b));
        }
        public void Add(int a,int b,int c)
        {
            Console.WriteLine("Add: " + (a + b + c));
        }
        public void Add(double a,double b)
        {
            Console.WriteLine("Add: " + (a + b));
        }
        }
    class Demo3
    {
        public static void Main()
        {
            Calculate obj = new Calculate();
            obj.Add(1, 2);
            obj.Add(12.2, 23.4);
            obj.Add(1, 2, 4);

        }
    }
}
