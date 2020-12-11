using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebMarket.Entities
{
    public partial class Customer
    {
        public Customer()
        {
            Account = new HashSet<Account>();
            Cart = new HashSet<Cart>();
            Order = new HashSet<Order>();
        }
        
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Image { get; set; }
        public string Email { get; set; }
        public int Status { get; set; }

        public virtual ICollection<Account> Account { get; set; }
        public virtual ICollection<Cart> Cart { get; set; }
        public virtual ICollection<Order> Order { get; set; }
    }
}
