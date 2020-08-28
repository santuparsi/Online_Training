using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HandsOnAPIUsingModel.Models;
namespace HandsOnAPIUsingModel.Repositrories
{
    public class ProductRepository
    {
        public static List<Product> products = new List<Product>()
        {
            new Product(){Pid=1,Pname="Soap",Price=15,Stock=100},
            new Product(){Pid=2,Pname="Bresh",Price=29,Stock=100},
        }; //inmomory data
        //add new product details
        public void Add(Product item)
        {
            products.Add(item);
        }
        //get all product values
        public List<Product> GetAll()
        {
            return products;
        }
        //get product by id
        public Product Get(int id)
        {
            foreach (Product p in products)
            {
                if (p.Pid == id)
                {
                    return p;
                }

            }
            return null;
        }

    }
}
