using Infrastructure.Domain;
using System;
using System.Collections.Generic;

namespace TeknikMarket.Model.Entity
{
    public partial class OfferType : BaseEntity, IBaseDomain
	{
    

        public string? Type { get; set; }

        public virtual Offer? IdNavigation { get; set; }
    }
}
