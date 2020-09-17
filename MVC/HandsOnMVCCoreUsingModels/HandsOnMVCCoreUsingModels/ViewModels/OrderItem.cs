using HandsOnMVCCoreUsingModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HandsOnMVCCoreUsingModels.ViewModels
{
    public class OrderItem
    {
        public Order Order { get; set; }
        public Item Item { get; set; }
    }
}
