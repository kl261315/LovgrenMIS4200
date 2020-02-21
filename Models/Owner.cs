using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace LovgrenMIS4200.Models
{
    public class Owner
    {
        public int ownerID { get; set; }

        [Display(Name = "Owner Last Name")]
        [Required(ErrorMessage ="Owner last name required!")]
        [StringLength(20)]
        public string ownerLastName { get; set; }

        [Display(Name = "Owner First Name")]
        [Required(ErrorMessage = "Owner first name required!")]
        [StringLength(20)]
        public string ownerFirstName { get; set; }

        [Display(Name = "Email")]
        [Required]
        [EmailAddress(ErrorMessage ="Enter your most frequently use email address")]
        public string email { get; set; }

        [Display(Name = "Phone Number")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^(\(\d{3}\) |\d{3}-)\d{3}-\d{4}$", ErrorMessage ="Phone numbers must be in the format xxx-xxx-xxxx or (xxx) xxx-xxxx")]
        public string phone { get; set; }
        public string fullName { get { return ownerLastName + ", " + ownerFirstName; } }

    }
}