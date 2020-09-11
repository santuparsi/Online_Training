using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HandsOnEnityFrameworkUsingDtos.DTOs
{
    public class ItemDTO
    {
        public string ItemId { get; set; }
        public string Name { get; set; }
        public int? Price { get; set; }
        public int? Stock { get; set; }
    }
}
