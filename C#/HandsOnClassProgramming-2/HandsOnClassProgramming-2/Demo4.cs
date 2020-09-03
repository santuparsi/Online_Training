using System;
using System.Collections.Generic;
using System.Text;

namespace HandsOnClassProgramming_2
{
    class A
    {
        public void f1()
        {

        }
    }
    class B:A
    {
        public void f()
        {
           // f1();
        }
        public void f2()
        {

        }
    }


    class Demo4
    {
        static void Main()
        {
            B obj = new B();
            obj.f1();
        }
    }
}
