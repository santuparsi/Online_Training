using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HandsOnHelpers.Models;
namespace HandsOnHelpers.Repositories
{
    public class UserRepository
    {
        public static List<User> list = new List<User>();
        public void Add(User item)
        {
            list.Add(item);
        }
    }
}
