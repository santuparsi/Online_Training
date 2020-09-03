using System;
using System.Collections.Generic;
using System.Text;

namespace HandsOnClassProgramming_2
{
    class X
    {
        private int a;
        public int b;
        internal int c;
        protected int d;
        protected internal int e;
    }
    class Y:X
    {
        public void f()
        {
            b = 10;
            c = 12;
            d = 20;
            e = 21;
        }
    }

    class Demo5
    {
        static void Main()
        {
            
            Y obj = new Y();
            obj.b = 10;
            obj.c = 20;
            obj.e = 12;
            X obj1 = new X();
            
            
        }
    }
}
