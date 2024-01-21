﻿using Infrastructure.Domain;
using System;
using System.Collections.Generic;

namespace TeknikMarket.Model.Entity
{
    public partial class OrderOffer : BaseEntity, IBaseDomain
	{
    
  
        public int? OrderId { get; set; }
        public int? OfferId { get; set; }
        
        public virtual Offer? Offer { get; set; }
        public virtual Order? Order { get; set; }
    }
}
