using System;
using System.Collections.Generic;
using System.Text;

namespace HandsOnTypeOfClasses
{
   public abstract class Shape
    {
        //abstract classes are not instatiated
        public void Dimension()
        {
            Console.WriteLine("I am 2D shape");
        }
        public abstract double Area();
    }
     class Circle:Shape
    {
        double r;
        public Circle(double r)
        {
            this.r = r;
        }
        public override double Area()
        {
            return Math.PI * r * r;
        }
        public void PeriMeter()
        {

        }
    }

    class Demo2
    {
        static void Main()
        {
            Circle c = new Circle(12.3);
            c.Dimension();
            Console.WriteLine("Area of Circle " + c.Area());
            c.PeriMeter();
            Shape s = new Circle(14.3);
            s.Dimension();
            s.Area();
           
        }
    }
}
