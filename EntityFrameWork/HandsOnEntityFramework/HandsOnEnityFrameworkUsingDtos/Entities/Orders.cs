using System;
using System.Collections.Generic;

namespace HandsOnEnityFrameworkUsingDtos.Entities
{
    public partial class Orders
    {
        public string OrderId { get; set; }
        public DateTime? OrderDate { get; set; }
        public string ItemId { get; set; }

        public virtual Items Item { get; set; }
    }
}
