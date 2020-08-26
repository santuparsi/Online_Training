using System;
using System.Collections;
namespace HandsOnNonGenericCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList ar = new ArrayList();
            ar.Add(10);
            ar.Add(12.3);
            ar.Add("David");
            ar.Add('a');
            ar.Add(true);
            int k = (int)ar[0];
            char ch = (char)ar[3];
            Console.WriteLine("Size: " + ar.Count);
            ar.Add(23);
            Console.WriteLine("Size: " + ar.Count);
            foreach (var i in ar)
                Console.WriteLine(i);
            Console.WriteLine("Hello World!");
            ar.Remove('a');
            Console.WriteLine("Size: " + ar.Count);
        }
    }
}
