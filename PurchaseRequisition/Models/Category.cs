using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PurchaseRequisition.Models
{
    public class Category
    {
        [DataType(DataType.Text), MaxLength(75)]
        public string Name { get; set; }

        [DefaultValue(true)]
        public bool Active { get; set; } = true;

        [InverseProperty(nameof(Order.Category))]
        public List<Order> Orders { get; set; }
    }
}
