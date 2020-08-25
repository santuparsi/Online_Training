//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace DemoOnArrays
//{
//    class Demo1
//    {
//        public static void Main()
//        {
//            string[,] logins = new string[3, 2]
//            {
//                {"Rohan","12345" },
//                {"Karan","12345" },
//                {"Krishna","12345" },
//            };
//            Console.WriteLine("Enter Username");
//            string uname = Console.ReadLine();
//            Console.WriteLine("Enter Password");
//            string pwd = Console.ReadLine();
//            bool flag = false;
//            for(int i=0;i<3;i++)
//            {
//                if(logins[i,0].Equals(uname) && logins[i,1].Equals(pwd))
//                {
//                    flag = true;
//                    break;
//                }
//            }
//            if (flag)
//                Console.WriteLine("Valid User");
//            else
//                Console.WriteLine("Invalid User");

//        }
//    }
//}
