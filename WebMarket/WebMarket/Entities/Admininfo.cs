using System;
using System.Collections.Generic;

namespace WebMarket.Entities
{
    public partial class Admininfo
    {
        public Admininfo()
        {
            Order = new HashSet<Order>();
            Priceupdate = new HashSet<Priceupdate>();
        }

        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public int Type { get; set; }

        public virtual ICollection<Order> Order { get; set; }
        public virtual ICollection<Priceupdate> Priceupdate { get; set; }
    }
}
