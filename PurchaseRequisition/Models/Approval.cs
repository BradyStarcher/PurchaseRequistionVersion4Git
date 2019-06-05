using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PurchaseRequisition.Models
{
    public class Approval
    {
        [DataType(DataType.Text), MaxLength(20)]
        public string Name { get; set; }

        [InverseProperty(nameof(SupervisorApproval.Approval))]
        public List<SupervisorApproval> SupervisorApprovals { get; set; } = new List<SupervisorApproval>();
    }
}
