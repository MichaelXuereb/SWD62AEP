using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ShoppingCart.Domain.Models
{
    class ProductImage
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public Product Product { get; set; }
        [ForeignKey("Product")]
        public Guid ProductId { get; set; }

        //ShoppingCartDbContext 
        //compile
        //add-migration "addingproductimage" -Context ShoppingCartDbContext
        //update-database -Context ShoppingCartDbContext
    }
}
