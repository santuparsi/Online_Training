using System;
using System.Collections.Generic;
using System.Text;

namespace DemoOnArrays
{
    class Demo1
    {
        static void Main()
        {
            
            //Jagged Array
            int[][] jagged_array = new int[3][];
            jagged_array[0] = new int[5] { 12, 23, 45, 56, 34 };
            jagged_array[1] =new int[3]{ 12,23,34};
            jagged_array[2] = new int[2] { 23, 34 };
            for(int i=0;i<jagged_array.Length;i++)
            {
                foreach (var k in jagged_array[i])
                {
                    Console.Write(k + " ");
                }
                Console.WriteLine();
            }
           
        }
    }
}
