using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PurchaseRequisition.Models
{
    public class BudgetAmount
    {
        public int ID { get; set; }

        [DataType(DataType.Currency)]
        public decimal TotalAmount { get; set; }

        [ForeignKey(nameof(ID))]
        public Budget BudgetCode { get; set; }
    }
}
