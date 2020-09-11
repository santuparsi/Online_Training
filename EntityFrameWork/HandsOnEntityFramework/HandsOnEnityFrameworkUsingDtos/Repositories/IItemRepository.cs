using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HandsOnEnityFrameworkUsingDtos.Entities;
namespace HandsOnEnityFrameworkUsingDtos.Repositories
{
    interface IItemRepository
    {
        List<Items> GetItems();
        Items Get(int id);
        void Add(Items obj);
        void Update(Items obj);
        void Delete(int id);
    }
}
