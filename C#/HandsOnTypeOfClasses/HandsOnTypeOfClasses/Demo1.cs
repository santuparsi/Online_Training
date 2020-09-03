using System;
using System.Collections.Generic;
using System.Text;

namespace HandsOnTypeOfClasses
{
    class A
    {
        public void f() { }
    }
    sealed class B : A
    {
        public void f1() { }
    }
    //class C : B { } //B is not inherited with C because of sealed


    class Demo1
    {
        static void Main()
        {
            B obj = new B();
        }
    }
}
