using System;

namespace HandsOnArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 10;
            int[] a = new int[5]; //array declaration
            //assign values
            a[0] = 12;
            a[1] = 20;
            a[2] = 40;
            Console.WriteLine(i);
            Console.WriteLine(a[0]);
            Console.WriteLine(a[4]);
           // Console.WriteLine(a[10]); exception
            foreach(int k in a)
            {
                Console.WriteLine(k);
            }
            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }
    }
}
