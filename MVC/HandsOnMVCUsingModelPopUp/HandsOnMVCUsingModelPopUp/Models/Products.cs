using System;
using System.Collections.Generic;

namespace HandsOnMVCUsingModelPopUp.Models
{
   
    public partial class Products
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public decimal? UnitPrice { get; set; }
    }
}
