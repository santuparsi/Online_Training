using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HandsOnHelpers.Models;
namespace HandsOnHelpers.Repositories
{
    public class CredentialsRepository
    {
        public static List<Credentials> list = new List<Credentials>()
        {
            new Credentials(){UserId="U0001",Uname="Sachin",Password="12345"}
        };
        public Credentials Validate(Credentials cred)
        {
            Credentials credentials = list.SingleOrDefault(c => c.Uname == cred.Uname && c.Password ==cred.Password);
            return credentials;
        }

    }
}
