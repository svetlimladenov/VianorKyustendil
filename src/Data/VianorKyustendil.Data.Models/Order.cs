using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace VianorKyustendil.Data.Models
{
    public class Order
    {
        public Order()
        {
            this.OrderDetails = new HashSet<OrderDetail>();
        }

        public string Id { get; set; }

        public DateTime OrderData { get; set; }

        public string Status { get; set; }

        public string Comments { get; set; }

        public string UserId { get; set; }

        [ForeignKey("UserId")]
        public virtual VianorKyustendilUser User { get; set; }

        public ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
