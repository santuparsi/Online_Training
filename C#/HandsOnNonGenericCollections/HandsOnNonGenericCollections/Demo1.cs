using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
namespace HandsOnNonGenericCollections
{
    class Demo1
    {
        public static void Main()
        {
            ArrayList ar = new ArrayList() { 12, 23, 34, 45, 56,10 };
            ar.Sort();
            int k = (int)ar[0];
            List<int> list = new List<int>() { 12, 34, 45, 56, 67, 78 };
            k = list[0];


        }
    }
}
