using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PurchaseRequisition.ViewModels
{
    public class User_in_Role
    {
        public string UserId { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "User Name")]
        public string Username { get; set; }

        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        public string Role { get; set; }
    }
}
