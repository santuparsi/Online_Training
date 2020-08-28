using System;
using System.Collections.Generic;
using System.Text;

namespace HandsOnNonGenericCollections
{
    class Demo3
    {
        static void Main()
        {
            string[] str = new string[] { "Chennai", "Madurai" };
            Dictionary<int, string> d1 = new Dictionary<int, string>();
            Dictionary<string, string[]> d2 = new Dictionary<string, string[]>();
            d2.Add("Kerala", new string[] { "Kochi", "Allipi" });
            d2.Add("AP", new string[] { "Hyderabad", "Vizag" });
            d2.Add("Tamilnadu", str);
            foreach(var k in d2.Keys)
            {
                Console.Write("Cities in {0} ", k);
                foreach(var i in d2[k])
                {
                    Console.Write(i+"");
                }
                Console.WriteLine();
            }
        }
    }
}
