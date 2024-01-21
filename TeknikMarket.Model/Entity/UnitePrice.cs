using Infrastructure.Domain;
using System;
using System.Collections.Generic;

namespace TeknikMarket.Model.Entity
{
    public partial class UnitePrice : BaseEntity, IBaseDomain
	{
    
      
        public string? UniteName { get; set; }
    
    }
}
