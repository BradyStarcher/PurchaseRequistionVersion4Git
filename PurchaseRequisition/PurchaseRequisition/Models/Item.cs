using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PurchaseRequisition.Models
{
    public class Item
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        [DataType(DataType.Currency)]
        public decimal PricePerUnit { get; set; }

        [DataType(DataType.Currency)]
        public int RequestedPrice { get; set; }

        public int Quanity { get; set; }

        [DataType(DataType.Currency)]
        public int TotalPrice { get; set; }

        public string FileAttachment { get; set; }

        public string Vendor { get; set; }

        [DefaultValue(true)]
        public bool Chosen { get; set; } = true;

        public string Justification { get; set; }
    }
}
