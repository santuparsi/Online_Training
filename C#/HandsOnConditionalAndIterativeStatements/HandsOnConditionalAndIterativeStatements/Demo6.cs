//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace HandsOnConditionalAndIterativeStatements
//{
//    class Demo4
//    {
//        static void Main()
//        {
//            Console.WriteLine("Enter your Name");
//            string name = Console.ReadLine(); //reads value from input
//            //Console.WriteLine("Hello " + name);
//            Console.WriteLine("Enter your Age");
//            int no = int.Parse(Console.ReadLine()); //Parse() converts string into any primitive type
//            Console.WriteLine(" Hello {0} Your Age is {1} ", name,no);
//            double d = 12.34;
//            int k = (int)d; //casting
//            int i = 10;
//            byte b = (byte)i;
//            object o = 12;
//            object o1 = 12.34;
//            k = (int)o; //unboxing
//            d = (double)o1;
//            string s = "129";
//            // int j = int.Parse(s);
//            //Convert class methods are use to convert value from one type to another type
//            int j = Convert.ToInt32(s); //coverts string to int
//            j = Convert.ToInt32(12.34);
//            double d1= Convert.ToDouble(s); //converts string to double
//        }
//    }
//}
