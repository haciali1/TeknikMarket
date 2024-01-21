using Infrastructure.Domain;
using System;
using System.Collections.Generic;

namespace TeknikMarket.Model.Entity
{
    public partial class Product : BaseEntity, IBaseDomain
	{
    
        public Product()
        {
            Baskets = new HashSet<Basket>();
            InstallmentOptions = new HashSet<InstallmentOption>();
            ProductImages = new HashSet<ProductImage>();
            ProductPrices = new HashSet<ProductPrice>();
        }

       
        public string? Name { get; set; }
        public string? Expllanation { get; set; }
        public int? CategoriyId { get; set; }
        public int? Stock { get; set; }


        public virtual Category? Categoriy { get; set; }
        public virtual ICollection<Basket> Baskets { get; set; }
        public virtual ICollection<InstallmentOption> InstallmentOptions { get; set; }
        public virtual ICollection<ProductImage> ProductImages { get; set; }
        public virtual ICollection<ProductPrice> ProductPrices { get; set; }
    }
}
