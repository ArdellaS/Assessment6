using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Assessment5.Models
{
    public class RSVPInfo
    {
        private string fName;
        private string lName;
        private string email;
        private bool attend;
        private bool guest;

        [DisplayName("First Name")]
        [Required]
        [MinLength(3)]
        public string FName { get => fName; set => fName = value; }

        [DisplayName("Last Name")]
        [Required]
        [MinLength(3)]
        public string LName { get => lName; set => lName = value; }

        [DisplayName("Email")]
        [Required]
        [EmailAddress]
        public string Email { get => email; set => email = value; }

        [DisplayName("Will you be attending?")]
        [Required]
        [MinLength(3)]
        public bool Attend { get => attend; set => attend = value; }

        [DisplayName("Will you be bringing guests? (Limit one guest)")]
        public bool Guest { get => guest; set => guest = value; }
    }
}
