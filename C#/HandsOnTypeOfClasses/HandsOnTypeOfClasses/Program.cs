using System;

namespace HandsOnTypeOfClasses
{
   public static class Compute
    {
        //difine only static members
        //static classes are not inherited
        //static classes are not instantiated
        public static int Add(int a,int b)
        {
            return a + b;
        }
        public static int Sub(int a,int b)
        {
            return a - b;
        }
        public static int Mul(int a,int b)
        {
            return a * b;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Compute.Add(2, 3);
            Compute.Mul(2, 3);
            Compute.Sub(3, 1);
        }
    }
}
