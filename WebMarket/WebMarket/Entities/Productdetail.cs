using System;
using System.Collections.Generic;

namespace WebMarket.Entities
{
    public partial class Productdetail
    {
        public Productdetail()
        {
            Warehouse = new HashSet<Warehouse>();
        }

        public int Id { get; set; }
        public int IdProduct { get; set; }
        public int Quantity { get; set; }
        public DateTime EntryDate { get; set; }
        public DateTime Mfg { get; set; }
        public DateTime Exp { get; set; }

        public virtual Product IdProductNavigation { get; set; }
        public virtual ICollection<Warehouse> Warehouse { get; set; }
    }
}
