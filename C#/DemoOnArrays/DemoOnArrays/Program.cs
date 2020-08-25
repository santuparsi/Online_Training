using System;

namespace DemoOnArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //array delclaration
            int[] a = new int[5];
            //assign values
            a[0] = 10;
            a[1] = 20;
            a[2] = 23;
           // a[3] = 4;
            a[4] = 50;
            //access array values
            int k = a[1];
            Console.WriteLine(a[2]);
           try
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine(a[i]);
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error: "+ex.Message);
            }
            int sum = 0;
            //using foreach
            foreach(int n in a)
            {
                sum = sum + n;
                Console.WriteLine(n);
            }
            Console.WriteLine("Sum or Array values {0} ", sum);
                Console.WriteLine("Hello World!");
        }
    }
}
