using HandsOnEnityFrameworkUsingDtos.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HandsOnEnityFrameworkUsingDtos.Entities;
namespace HandsOnEnityFrameworkUsingDtos.Repositories
{
    public class ItemRepositoty : IItemRepository
    {
        private ShopDBContext context = null;
        public ItemRepositoty()
        {
            context = new ShopDBContext();
            //context = _context;
        }
        public void Add(Items obj)
        {
            context.Items.Add(obj);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            Items item = context.Items.Find(id);
            context.Items.Remove(item);
            context.SaveChanges();
        }

        public Items Get(int id)
        {
            Items item = context.Items.Find(id);
            return item;
        }

        public List<Items> GetItems()
        {
            List<Items> list = context.Items.ToList();
            return list;
        }

        public void Update(Items uObj)
        {
            context.Items.Update(uObj);
            context.SaveChanges();
        }
    }
}
