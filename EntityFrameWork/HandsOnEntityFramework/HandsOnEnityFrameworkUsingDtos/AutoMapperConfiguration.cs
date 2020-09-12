using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HandsOnEnityFrameworkUsingDtos.DTOs;
using HandsOnEnityFrameworkUsingDtos.Entities;
namespace HandsOnEnityFrameworkUsingDtos
{
    public class AutoMapperConfiguration:Profile
    {
        public AutoMapperConfiguration()
        {
            CreateMap<ItemDTO, Items>().ReverseMap();
            CreateMap<OrderDTO, Orders>().ReverseMap();
        }
    }
}
