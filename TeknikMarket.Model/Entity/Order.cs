using Infrastructure.Domain;
using System;
using System.Collections.Generic;

namespace TeknikMarket.Model.Entity
{
    public partial class Order : BaseEntity, IBaseDomain
	{
    
        public Order()
        {
            OrderOffers = new HashSet<OrderOffer>();
        }

      
        public DateTime? Date { get; set; }
        public int? UserId { get; set; }
        public decimal? TotalOrderPrice { get; set; }
        public int? Sale { get; set; }


        public virtual User? User { get; set; }
        public virtual ICollection<OrderOffer> OrderOffers { get; set; }
    }
}
