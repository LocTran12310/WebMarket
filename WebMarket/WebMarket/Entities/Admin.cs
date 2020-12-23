using System;
using System.Collections.Generic;

namespace WebMarket.Entities
{
    public partial class Admin
    {
        public Admin()
        {
            Order = new HashSet<Order>();
            Warehouse = new HashSet<Warehouse>();
        }

        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public int Type { get; set; }

        public virtual ICollection<Order> Order { get; set; }
        public virtual ICollection<Warehouse> Warehouse { get; set; }
    }
}
