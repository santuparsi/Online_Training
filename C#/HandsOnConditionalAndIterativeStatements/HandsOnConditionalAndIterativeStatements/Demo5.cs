//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace HandsOnConditionalAndIterativeStatements
//{
//    class Demo4
//    {
//        //while
//        public static void PrintName(string name)
//        {
//            int i = 1;
//            while(i<=10)
//            {
//                Console.WriteLine("Hello " + name);
//                i++;
//            }
//        }
//        //do-while
//        public static void PrintNaturalNos(int no)
//        {
//            int i = 1;
//            //while(i<=no)
//            //{
//            //    Console.Write(i + " ");
//            //    i++;
//            //}
//            do
//            {
//                Console.Write(i + " ");
//                i++;
//            } while (i >= no);
//        }
//        public static void WholeNumbers(int no)
//        {
//            //for(int i=0;i<=no;i++)
//            //{
//            //    Console.Write(i);
//            //}
//            //int i = 0;
//            //for(;i<=no;i++)
//            //{
//            //    Console.WriteLine(i);
//            //}
//            //int i = no;
//            //for(;i>=0;)
//            //{
//            //    Console.WriteLine(i);
//            //    i--;
//            //}
//            int i = 1;
//            for (; ;)
//            {
//                i++;
//                if (i % 2 == 0)

//                {

//                }
//                else
//                {
//                    continue;
//                }
//                Console.WriteLine(i);

//                if (i == no)
//                    break;
//            }
//        }

//        public static void Main()
//        {
//            //PrintName("Sachin");
//            // PrintNaturalNos(100);
//            WholeNumbers(100);
//        }
//    }
//}
