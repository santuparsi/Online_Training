using System;

namespace HandsClassProgramming
{
    class Customer
    {
        //private int cId;
        // private string cName;
        // private string country;
        public int cId;
        public string cName;
        public string country;
        public void Details()
        {
            Console.WriteLine("Customer ID: " + cId);
            Console.WriteLine("Customer Name: " + cName);
            Console.WriteLine("Country: " + country);
        }
        public static void Main()
        {
            //Instatiate customer
            Customer obj = new Customer();
            obj.cId = 100;
            obj.cName = "Rajan";
            obj.country = "India";
            obj.Details();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int[] no = new int[3] { 12, 34,23};
            string[] str = new string[2] { "Ram", "Krishna" };
            Customer c1 = new Customer();
            c1.cId = 100;
            c1.cName = "Krishna";
            c1.country = "India";
            //c1.Details();
            Customer c2 = new Customer() { cId = 101, cName = "David", country = "USA" };
            Customer c3 = new Customer() { cName = "Peter" };
            Customer[] list = new Customer[3] { c1, c2, c3 }; //array of Customers
            foreach(Customer c in list)
            {
                c.Details();
                Console.WriteLine("-----------------------------");
            }
            Console.WriteLine("Hello World!");
        }
    }
}
