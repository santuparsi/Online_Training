using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HandsOnMVCCoreUsingModels.Models
{
    public class Order
    {
        public string OrderId { get; set; }
        public int ItemId { get; set; }
        public DateTime OrderDate { get; set; }
    }
}
