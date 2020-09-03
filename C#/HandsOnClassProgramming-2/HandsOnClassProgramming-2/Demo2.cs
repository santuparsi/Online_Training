using System;
using System.Collections.Generic;
using System.Text;

namespace HandsOnClassProgramming_2
{
    class Product
    {
        private int pId;
        private string pName;
        public int PID
        {
            set { pId = value; } //set value to privat variable
            get { return pId; } //get value from private variable
        }
        public string PNAME
        {
            set { pName = value; }
            get { return pName; }
        }

        public void Show()
        {
            Console.WriteLine("PID: " + pId);
        }
    }

    class Demo2
    {

        static void Main()
        {
            Product obj = new Product();
            obj.PID = 101;
            int k = obj.PID;
            obj.Show();
        }
    }
}
