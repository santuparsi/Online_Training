using System;
using System.Collections;
namespace HandsOnInterfaces
{
    interface Ishape
    {
        int Area();
    }
    class Square:Ishape
    {
        int x;
        public Square(int x)
        {
            this.x = x;
        }
        public int Area()
        {
            return 4 * x;
        }
    }
    class Circle:Ishape
    {
        double r;
        public Circle(double r)
        {
            this.r = r;
        }
        public int Area()
        {
            return (int)(Math.PI * r * r);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            
        }
    }
}
