using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace HandsOnLinq
{
    class Demo1
    {
        static void Main()

        {
            string[] str = { "Rohan", "Karan", "Jeson", "Suren", "Krishna" };
            //fetch names starts with K
            var res = from string s in str
                      where s.StartsWith("K")
                      select s;
            res = str.Where(s => s.StartsWith("k"));
            //fetch values in sorted order
            var res1 = from s in str
                       where s.Length==5
                      orderby s descending
                      select s;
            res1 = str.Where(s => s.Length == 5).OrderBy(s => s);
            foreach (var k in res1)
                Console.WriteLine(k);
                    
        }
    }
}
