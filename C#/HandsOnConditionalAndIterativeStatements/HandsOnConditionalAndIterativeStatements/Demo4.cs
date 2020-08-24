//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace HandsOnConditionalAndIterativeStatements
//{
//    class Demo4
//    {
//        public static string GetDay(string inputday)
//        {
//            //switch case 
//            string day = inputday;
//            switch (day)
//            {
//                case "Monday":
//                case "Tuesday":
//                    {
//                        return "Working Day..";
//                       // Console.WriteLine("Working Day..");
//                    }
//                    break;
//                case "Wednesday":
//                    return "Meeting Day..";
//                    //Console.WriteLine("Meeting Day.."); break;
//                case "Friday":
//                case "Thusday":
//                    return "Festival Day..";
//                   // Console.WriteLine("Festival Day..");
//                    break;
//                case "Sunday":
//                case "Satarday":
//                    return "Holyday";
//                    //Console.WriteLine("Holyday");
//                    break;
//                default:
//                    return "Normal Day";
//                   // Console.WriteLine("Normal Day"); //default statements are optional
//                    break;
//            }
//        }
//       public static void Main()
//        {

//            GetDay("Sunday");
//            GetDay("Friday");
//        }
//    }
//}
