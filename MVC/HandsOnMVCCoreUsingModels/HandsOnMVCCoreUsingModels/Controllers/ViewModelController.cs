using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HandsOnMVCCoreUsingModels.Models;
using HandsOnMVCCoreUsingModels.ViewModels;
namespace HandsOnMVCCoreUsingModels.Controllers
{
    public class ViewModelController : Controller
    {
        public IActionResult Index()
        {
            Item item = new Item() { ItemId = 1, ItemName = "Pen", Price = 10, Stock = 10 };
            Order order = new Order() { OrderId = "O0001", ItemId = 1, OrderDate = DateTime.Now };
            OrderItem orderItem = new OrderItem() { Item = item, Order = order };
            return View(orderItem);
        }
        public IActionResult GetAll()
        {
            List<Item> item = new List<Item>() { new Item() { ItemId = 1, ItemName = "Pen", Price = 10, Stock = 10 } };
            List<Order> order = new List<Order>() { new Order() { OrderId = "O0001", ItemId = 1, OrderDate = DateTime.Now } };
            //ItemOrder itemOrder = (from i in item 
            //                       join 
            //                       o in order 
            //                       on i.ItemId equals o.ItemId
            //                       select new ItemOrder() 
            //                       { ItemName = i.ItemName, 
            //                           Price = i.Price, 
            //                           OrderId = o.OrderId, 
            //                           OrderDate = o.OrderDate 
            //                       }).SingleOrDefault();
            ItemOrder itemOrder = item.Join(order, i => i.ItemId, o => o.ItemId, (i, o) => new ItemOrder()
            {
                ItemName = i.ItemName,
                Price = i.Price,
                OrderId = o.OrderId,
                OrderDate = o.OrderDate
            }).SingleOrDefault();
            return View(itemOrder);
        }
    }
}
