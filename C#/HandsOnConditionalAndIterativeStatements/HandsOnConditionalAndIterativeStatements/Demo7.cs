using System;
using System.Collections.Generic;
using System.Text;

namespace HandsOnConditionalAndIterativeStatements
{
    class Demo4
    {
        static void Main()
        {
            Console.WriteLine("Enter no");
            int no = Convert.ToInt32(Console.ReadLine());
            do
            {
                Console.WriteLine("Menu");
                Console.WriteLine("1.Even/Odd");
                Console.WriteLine("2.Natural No's");
                Console.WriteLine("3.Math Table");
                Console.WriteLine("4.Exit");
                Console.WriteLine("Enter your Choice");
                int ch = int.Parse(Console.ReadLine());
                switch(ch)
                {
                    case 1:
                        if (no % 2 == 0)
                            Console.WriteLine("Even");
                        else
                            Console.WriteLine("Odd");
                        break;
                    case 2:
                        {
                            int i = 1;
                            while(i<=no)
                            {
                                Console.WriteLine(i);
                                i++;
                            }
                        }
                        break;
                    case 3:
                        {
                            for(int i=1;i<=10;i++)
                            {
                                Console.WriteLine("{0}*{1}={2}", no, i, (no * i));
                            }
                        }
                        break;
                    case 4:
                        return;
                    default:
                        Console.WriteLine("Select Correct Choice");
                        break;
                }

            } while (true);
        }
    }
}
