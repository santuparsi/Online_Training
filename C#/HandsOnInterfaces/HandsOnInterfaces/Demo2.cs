using System;
using System.Collections.Generic;
using System.Text;

namespace HandsOnInterfaces
{
    interface IMobile
    {
        void Discount();
    }
    interface ILaptop
    {
        void Discout();
    }
    class Shop:IMobile,ILaptop
    {
        void IMobile.Discount()
        {
            //difne discount for mobiles
        }
        void ILaptop.Discout()
        {
            //define discount for laptops
        }
    }
    class Demo2
    {
        public static void Main()
        {

        }
    }
}
