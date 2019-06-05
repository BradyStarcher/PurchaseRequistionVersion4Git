using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;

namespace PurchaseRequisition.Models
{
    public class Department
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public int DivisionID { get; set; }

        [ForeignKey(nameof(DivisionID))]
        public Division Division { get; set; }

        [DefaultValue(true)]
        public bool Active { get; set; } = true;

        [InverseProperty(nameof(User.Department))]
        public List<User> Employees { get; set; } = new List<User>();
    }
}
