using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace HandsOnEnityFrameworkUsingDtos.Entities
{
   
    public class OrderItem
    {
       
        public string ItemId { get; set; }
        public string Name { get; set; }
        public DateTime? OrderDate { get; set; }
    }
}
