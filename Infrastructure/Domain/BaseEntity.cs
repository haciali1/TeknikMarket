﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Domain
{
	public class BaseEntity
	{
		public int Id { get; set; }
        public int Creater { get; set; }
        public DateTime CreatedDate  { get; set; }
		public DateTime? UpdateData { get; set; }
		public int LastProcessUser { get; set; }
        public bool IsDeleted { get; set; }
    }
}
