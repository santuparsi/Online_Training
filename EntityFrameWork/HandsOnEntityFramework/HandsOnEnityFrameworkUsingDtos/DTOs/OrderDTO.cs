using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HandsOnEnityFrameworkUsingDtos.DTOs
{
    public class OrderDTO
    {
        public string OrderId { get; set; }
        public DateTime? OrderDate { get; set; }
        public string ItemId { get; set; }
    }
}
