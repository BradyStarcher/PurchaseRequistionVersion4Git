using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PurchaseRequisition.Models
{
    public class Budget
    {
        public int ID { get; set; }

        [Required]
        [DataType(DataType.Text)]
        public string Name { get; set; }

        [Required]
        public int DACode { get; set; }

        [Required]
        public bool Type { get; set; }

        [DefaultValue(true)]
        public bool Active { get; set; } = true;

        [InverseProperty(nameof(BudgetAmount.BudgetCode))]
        public List<BudgetAmount> BudgetAmounts { get; set; } = new List<BudgetAmount>();

        [InverseProperty(nameof(EmployeeBudgetCode.BudgetCode))]
        public List<EmployeeBudgetCode> EmployeesBudgetCode { get; set; } = new List<EmployeeBudgetCode>();

        [InverseProperty(nameof(Order.BudgetCode))]
        public List<Order> Orders { get; set; } = new List<Order>();
    }
}