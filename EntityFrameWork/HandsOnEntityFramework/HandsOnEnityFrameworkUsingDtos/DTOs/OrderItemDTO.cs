using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HandsOnEnityFrameworkUsingDtos.DTOs
{
    public class OrderItemDTO
    {
        public string ItemId { get; set; }
        public string Name { get; set; }
        public DateTime? OrderDate { get; set; }
    }
}
