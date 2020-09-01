using System;
using System.Collections.Generic;
using System.Text;

namespace HandsClassProgramming
{
    class Rectangle
    {
        private int length, width;
        public Rectangle(int length,int width)
        {
            this.length = length;
            this.width = width;
        }
        public Rectangle(int l)
        {
            length = l;
            width = 2 * length;
        }
        public int Area()
        {
            int res = length * width;
            return res;
        }
    }

    class Demo2
    {
        public static void Main()
        {
            Rectangle r1 = new Rectangle(12, 12);
            Rectangle r2 = new Rectangle(24, 34);
            Rectangle[] list = new Rectangle[2] { r1, r2 };
            foreach(Rectangle r in list )
            {
                Console.WriteLine("Area: " + r.Area());
            }
        }
    }
}
