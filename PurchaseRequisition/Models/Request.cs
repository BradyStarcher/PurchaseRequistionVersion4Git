using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PurchaseRequisition.Models
{
    public class Request
    {
        [Display(Name = "Quantity Requested")]
        public int QuantityRequested { get; set; }

        [Display(Name = "Estimated Cost")]
        [DataType(DataType.Currency)]
        public decimal EstimatedCost { get; set; }

        [Display(Name = "Estimated Total")]
        [DataType(DataType.Currency)]
        public decimal EstimatedTotal { get; set; }

        [Display(Name = "Paid Cost")]
        [DataType(DataType.Currency)]
        public decimal PaidCost { get; set; }

        [Display(Name = "Paid Total")]
        [DataType(DataType.Currency)]
        public decimal PaidTotal { get; set; }

        [DefaultValue(true)]
        public bool Chosen { get; set; } = true;

        public int OrderID { get; set; }

        [ForeignKey(nameof(OrderID))]
        public Order Order { get; set; }

        [InverseProperty(nameof(FileAttachment.Request))]
        public List<FileAttachment> Attachments { get; set; } = new List<FileAttachment>();

        public int? VendorID { get; set; }

        [ForeignKey(nameof(VendorID))]
        public Vendor Vendor { get; set; }

        public int ItemID { get; set; }

        [ForeignKey(nameof(ItemID))]
        public Item Item { get; set; }

        public string ReasonChosen { get; set; }
    }
}
