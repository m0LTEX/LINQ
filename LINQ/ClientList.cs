using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
   public class ClientList
    {
        public static readonly List<Client> Clients = new
            List<Client>
        {
        new Client()
            {
            Id = 1,
            Name = "Antoni",
            City = "Tallinn",
            },
        new Client()
            {
            Id = 2,
            Name = "Eric",
            City = "Kiviõli",
            },
        new Client()
            {
            Id = 3,
            Name = "Armand",
            City = "Tartu",
            },
        new Client()
            {
            Id = 4,
            Name = "Robin",
            City = "Pärnu",
            },
        new Client()
            {
            Id = 5,
            Name = "Kermo",
            City = "Viljandi",
            },
        };
   }
}
