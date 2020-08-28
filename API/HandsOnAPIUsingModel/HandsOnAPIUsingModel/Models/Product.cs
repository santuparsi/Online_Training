using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HandsOnAPIUsingModel.Models
{
    public class Product
    {
        public int Pid { get; set; }
        public string Pname { get; set; }
        public double Price { get; set; }
        public int Stock { get; set; }
    }
}
