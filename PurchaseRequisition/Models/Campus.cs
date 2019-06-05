using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PurchaseRequisition.Models
{
    public class Campus
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public int AddressID { get; set; }

        [ForeignKey(nameof(AddressID))]
        public Address Address { get; set; }

        public College College { get; set; }

        [DefaultValue(true)]
        public bool Active { get; set; } = true;
    }
}
