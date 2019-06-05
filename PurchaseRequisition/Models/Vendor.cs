using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PurchaseRequisition.Models
{
    public class Vendor
    {
        [DataType(DataType.Text), MaxLength(20)]
        public string Name { get; set; }

        [DataType(DataType.Text), MaxLength(20)]
        public string Phone { get; set; }

        [DataType(DataType.Text), MaxLength(20)]
        public string Fax { get; set; }

        [DataType(DataType.Text), MaxLength(20)]
        public string URL { get; set; }

        [InverseProperty(nameof(Request.Vendor))]
        public List<Request> Requests { get; set; } = new List<Request>();

        public int AddressID { get; set; }

        [ForeignKey(nameof(AddressID))]
        public Address Address { get; set; }
    }
}
