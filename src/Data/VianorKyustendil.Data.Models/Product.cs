using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace VianorKyustendil.Data.Models
{
    public class Product
    {
        public Product()
        {
            this.OrderDetails = new HashSet<OrderDetail>();
        }

        public string Id { get; set; }

        public string ProductName { get; set; }

        public string Description { get; set; }

        public string PictureUrl { get; set; }

        public decimal Price { get; set; }

        public int QuantityInStock { get; set; }

        public string CategoryId { get; set; }

        [ForeignKey("CategoryId")]
        public virtual Category Category { get; set; }

        public ICollection<OrderDetail> OrderDetails { get; set; }
    }
}