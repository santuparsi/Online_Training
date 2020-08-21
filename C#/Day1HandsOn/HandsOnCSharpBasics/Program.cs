using System;
using System.Collections;

namespace HandsOnCSharpBasics
{
    class Program
    {
        double salary = 12000; //class variable
        static void Main(string[] args)
        {
            //value data types
            //integer types
            byte b = 10; //local variables
            short s1 = 32489;
            int i = 324034;
            long l = 3428932490;
            //decimal types
            double d = 12.345;
            float f = 12.34f;
            decimal m = 12.323409834m;
            m = b * i;
            //char type
            char ch = 'a';
            //bool type
            bool result = true;
            int k = 10;
            //reference types
            string str = "Hello User";
            object o = 12;
            o = 12.34;
            o = "David";
            o = new ArrayList();
            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }
    }
}
