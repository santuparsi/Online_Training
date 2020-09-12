using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using AutoMapper;
using HandsOnEnityFrameworkUsingDtos.DTOs;
using HandsOnEnityFrameworkUsingDtos.Entities;
using HandsOnEnityFrameworkUsingDtos.Repositories;

namespace HandsOnEnityFrameworkUsingDtos.Services
{
    public class ItemService
    {
        private ItemRepositoty _repo;
        private IMapper _mapper;
        public ItemService(IMapper mapper)
        {
            _mapper = mapper;
            _repo = new ItemRepositoty();
        }
        public void Add(ItemDTO item)
        {
            //Items obj = new Items()
            //{
            //    ItemId = item.ItemId,
            //    Name = item.Name,
            //    Price = item.Price,
            //    Stock = item.Stock
            //};
          //  item.ItemId = new Random().Next().ToString();
            Items obj = _mapper.Map<Items>(item);
            _repo.Add(obj);

        }
        public List<ItemDTO> GetAll()
        {
            List<Items> list = _repo.GetItems();
            //List<ItemDTO> list1= _mapper.Map<List<ItemDTO>>(list);
            //return list1;
            return _mapper.Map<List<ItemDTO>>(list);
        }
        public ItemDTO GetById(string Id)
        {
            return _mapper.Map<ItemDTO>(_repo.Get(Id));
        }
        public void Update(ItemDTO item)
        {
            _repo.Update(_mapper.Map<Items>(item));
        }
        public void Delete(string Id)
        {
            _repo.Delete(Id);
        }
        
    }
}
