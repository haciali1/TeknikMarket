﻿using Infrastructure.Domain;
using System;
using System.Collections.Generic;

namespace TeknikMarket.Model.Entity
{
    public partial class City : BaseEntity, IBaseDomain
	{
    
        public City()
        {
            Admins = new HashSet<Admin>();
            Users = new HashSet<User>();
        }

       
        public string? Name { get; set; }
        public int? PlateCode { get; set; }


        public virtual ICollection<Admin> Admins { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}
