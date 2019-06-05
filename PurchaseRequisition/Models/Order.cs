using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PurchaseRequisition.Models
{
    public class Order
    {
        [DataType(DataType.Date)]
        public DateTime DateMade { get; set; }

        [DataType(DataType.Date)]
        public DateTime? DateOrdered { get; set; }

        [DefaultValue(false)]
        public bool StateContract { get; set; }

        [DataType(DataType.MultilineText)]
        public string BusinessJustification { get; set; }

        [Required]
        public string EmployeeID { get; set; }

        [ForeignKey(nameof(EmployeeID))]
        public User Employee { get; set; }

        public int StatusID { get; set; }

        [ForeignKey(nameof(StatusID))]
        public Status Status { get; set; }

        public int? CategoryId { get; set; }

        [ForeignKey(nameof(CategoryId))]
        public Category Category { get; set; }


        [InverseProperty(nameof(SupervisorApproval.Order))]
        public List<SupervisorApproval> SupervisorApprovals { get; set; }

        [InverseProperty(nameof(Request.Order))]
        public List<Request> Requests { get; set; }

        public int? BudgetCodeId { get; set; }

        [ForeignKey(nameof(BudgetCodeId))]
        public Budget BudgetCode { get; set; }
    }
}
