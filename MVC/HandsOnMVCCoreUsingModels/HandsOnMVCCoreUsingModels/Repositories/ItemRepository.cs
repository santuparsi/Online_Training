using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HandsOnMVCCoreUsingModels.Models;
namespace HandsOnMVCCoreUsingModels.Repositories
{
    public class ItemRepository
    {
        public static List<Item> list;
        public ItemRepository()

        {
            list = new List<Item>() {
            new Item(){ItemId=1,ItemName="Pen",Price=10,Stock=100},
            new Item(){ItemId=2,ItemName="Pencil",Price=10,Stock=100}
            };
        }
        public void Add(Item item)
        {
            list.Add(item); //adding item
        }
        public Item Get(int id)
        {
            return list.SingleOrDefault(i => i.ItemId == id);
        }
        public List<Item> GetAll()
        {
            return list;
        }
    }
}
