using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PurchaseRequisition.Models
{
    public class Item
    {
        public int ID { get; set; }

        [DataType(DataType.Text), MaxLength(50)]
        public string Name { get; set; }

        [DataType(DataType.Text), MaxLength(200)]
        public string Description { get; set; }

        [InverseProperty(nameof(Request.Item))]
        public List<Request> Requests { get; set; } = new List<Request>();
    }
}