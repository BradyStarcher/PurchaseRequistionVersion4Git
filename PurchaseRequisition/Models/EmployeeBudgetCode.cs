using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PurchaseRequisition.Models
{
    public class EmployeeBudgetCode
    {
        public string ID { get; set; }

        [DefaultValue(true)]
        public bool Active { get; set; } = true;

        [ForeignKey(nameof(ID))]
        public User Employee { get; set; }

        public int BudgetCodeID { get; set; }

        [ForeignKey(nameof(BudgetCodeID))]
        public Budget BudgetCode { get; set; }
    }
}
