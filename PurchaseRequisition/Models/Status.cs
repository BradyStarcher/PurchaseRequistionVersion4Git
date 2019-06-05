using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PurchaseRequisition.Models
{
    public class Status
    {
        [DataType(DataType.Text), MaxLength(50)]
        public string Name { get; set; }

        [InverseProperty(nameof(Order.Status))]
        public List<Order> Orders { get; set; } = new List<Order>();
    }
}
