using System;
using System.Collections.Generic;
using System.Text;

namespace HandsOnConditionalAndIterativeStatements
{
    class Demo1
    {
        public static string GetResult(int m1,int m2,int m3,int m4,int m5)
        {
            int tot = m1 + m2 + m3 + m4 + m5;
            double avg = tot / 5;
            if(m1>=40 && m2>= 40&&m3 >= 40 && m4 >= 40 && m5>=40 )
            {
                if (avg >= 70)
                    return "Distinction"+"Total: "+tot;
                else if(avg>=60 && avg<70)
                {
                    return "FirstClass";
                }
                else if(avg>=50 && avg<60)
                {
                    return "Second Class";
                }  
                else
                {
                    return "Third Class";
                }
            }
            else
            {
                return "Fail";
            }
        }
         static void Main()
        {
            string result = GetResult(89, 87, 78, 67, 78);
            Console.WriteLine(result);
        }
    }
}
