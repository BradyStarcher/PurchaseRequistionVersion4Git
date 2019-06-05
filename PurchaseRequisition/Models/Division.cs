using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PurchaseRequisition.Models
{
    public class Division
    {
        public int ID { get; set; }

        public string Name { get; set; }

        [DefaultValue(true)]
        public bool Active { get; set; } = true;

        [InverseProperty(nameof(Department.Division))]
        public List<Department> Departments { get; set; } = new List<Department>();

        public string SupervisorId { get; set; }

        [ForeignKey(nameof(SupervisorId))]
        public User Supervisor { get; set; }
    }
}