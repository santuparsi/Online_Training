using System;

namespace HandsOnClassProgramming_2
{
    class Compute
    {
        public void Add(int a,int b)
        {
            Console.WriteLine(a + b);
        }
        public void Sub(int a,int b)
        {
            Console.WriteLine(a - b);
        }
        public static double Sqaure(double a)
        {
            return a * a;
            //Console.WriteLine(a * a);
        }
        public static void Mul(int a,int b)
        {
            Console.WriteLine(a * b);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Compute obj = new Compute();
            obj.Add(1, 2);
            obj.Sub(4, 2);
            Compute.Mul(3, 4);
            double sqaure = Compute.Sqaure(5);
            Console.WriteLine("Hello World!");
        }
    }
}
