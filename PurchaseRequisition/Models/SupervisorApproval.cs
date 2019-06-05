using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PurchaseRequisition.Models
{
    public class SupervisorApproval
    {
        public int ID { get; set; }

        [ForeignKey(nameof(ID))]
        public SupervisorApproval Approval { get; set; }

        public int OrderID { get; set; }

        [ForeignKey(nameof(OrderID))]
        public Order Order { get; set; }

        [Required]
        public string SupervisorID { get; set; }

        [Required]
        public string UserRoleID { get; set; }

        [ForeignKey(nameof(UserRoleID))]
        public IdentityRole IdentityRole { get; set; }

        [ForeignKey(nameof(SupervisorID))]
        public User Employee { get; set; }

        [DataType(DataType.MultilineText)]
        public string DeniedJustification { get; set; }
    }
}
