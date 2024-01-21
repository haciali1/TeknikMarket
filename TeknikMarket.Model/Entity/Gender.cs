﻿using Infrastructure.Domain;
using System;
using System.Collections.Generic;

namespace TeknikMarket.Model.Entity
{
    public partial class Gender : BaseEntity, IBaseDomain
	{
    
        public Gender()
        {
            Admins = new HashSet<Admin>();
            Users = new HashSet<User>();
        }


        public string? Name { get; set; }

        public virtual ICollection<Admin> Admins { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}
