using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace PurchaseRequisition.Models
{
    public class User : IdentityUser
    {
        public User() : base()
        {

        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int? DivisionID { get; set; }

        [ForeignKey(nameof(DivisionID))]
        public Division Division { get; set; }

        public int? DepartmentID { get; set; }

        [ForeignKey(nameof(DepartmentID))]
        public Department Department { get; set; }

        public string JobTitle { get; set; }

        public string StartDate { get; set; }

        public string EndDate { get; set; }

        public int? CampusID { get; set; }

        [ForeignKey(nameof(CampusID))]
        public Campus Campus { get; set; }


    }
}
