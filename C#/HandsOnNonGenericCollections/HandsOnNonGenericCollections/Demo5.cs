using System;
using System.Collections.Generic;
using System.Text;

namespace HandsOnNonGenericCollections
{
    class Demo5
    {
        static void Main()
        {
            Stack<int[]> s1 = new Stack<int[]>();
            s1.Push(new int[] { 1, 2 });
            s1.Push(new int[] { 2, 3, 4, 5 });
            foreach(var i in s1)
            {
                foreach(var j in i)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Stack<int> obj = new Stack<int>();
            //add items
            obj.Push(10);
            obj.Push(20);
            obj.Push(30);
            obj.Push(40);
            foreach(var i in obj)
            {
                Console.WriteLine(i);
            }
            //access top value
            int k = obj.Peek();
            Console.WriteLine(k);
            //pick and remove the top values
            Console.WriteLine("Poped Value "+obj.Pop());
            Console.WriteLine();
            foreach (var i in obj)
            {
                Console.WriteLine(i);
            }

        }
    }
}
