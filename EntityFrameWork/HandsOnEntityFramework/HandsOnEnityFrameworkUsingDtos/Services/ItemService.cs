using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HandsOnEnityFrameworkUsingDtos.DTOs;
using HandsOnEnityFrameworkUsingDtos.Entities;
using HandsOnEnityFrameworkUsingDtos.Repositories;

namespace HandsOnEnityFrameworkUsingDtos.Services
{
    public class ItemService
    {
        private ItemRepositoty _repo;
        public ItemService()
        {
            _repo = new ItemRepositoty();
        }
        public void Add(ItemDTO item)
        {
            Items obj = new Items()
            {
                ItemId = item.ItemId,
                Name = item.Name,
                Price = item.Price,
                Stock = item.Stock
            };
            _repo.Add(obj);

        }
    }
}
