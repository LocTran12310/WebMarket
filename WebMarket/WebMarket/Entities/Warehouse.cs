using System;
using System.Collections.Generic;

namespace WebMarket.Entities
{
    public partial class Warehouse
    {
        public int Id { get; set; }
        public int IdProductdetail { get; set; }
        public int IdAdmin { get; set; }

        public virtual Admin IdAdminNavigation { get; set; }
        public virtual Productdetail IdProductdetailNavigation { get; set; }
    }
}
