using System;
using System.Collections.Generic;
using System.Text;

namespace HandsOnNonGenericCollections
{
    class Demo6
    {
        static void Main()
        {
            Queue<string> n = new Queue<string>();
            //adding values
            n.Enqueue("Rohan");
            n.Enqueue("Suren");
            n.Enqueue("Ram");
            n.Enqueue("Krishna");
            foreach(var k in n)
            {
                Console.WriteLine(k);
            }
            Console.WriteLine("Peak: " + n.Peek());
            Console.WriteLine("Pop: " + n.Dequeue());
            List<int> l = new List<int>() { 1, 2, 4, 6, 8 };
            Queue<int> q1 = new Queue<int>();
            foreach(var k in l)
            {
                q1.Enqueue(k);
            }
        }
    }
}
