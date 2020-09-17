using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HandsOnMVCCoreUsingModels.ViewModels
{
    public class ItemOrder
    {
        public string ItemName { get; set; }
        public int Price { get; set; }
        public string OrderId { get; set; }
        public DateTime OrderDate { get; set; }
    }
}
