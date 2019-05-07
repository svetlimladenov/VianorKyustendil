using System;
using System.Collections.Generic;
using System.Text;

namespace VianorKyustendil.Data.Models
{
    public class OrderDetail
    {
        public string OrderId { get; set; }

        public virtual Order Order { get; set; }

        public string ProductId { get; set; }

        public virtual Product Product { get; set; }

        public int Quantity { get; set; }

        public decimal Discount { get; set; }
    }
}
