using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Assessment5.Models
{
    public class DishInfo
    {
     
        private string personName;
        private string phoneNumber;
        private string dishName;
        private string dishDescription;
        private bool selection;

        [DisplayName("Please enter full name")]
        [Required]
        public string PersonName { get => personName; set => personName = value; }

        [DisplayName("Please enter phone number")]
        [Required]
        [MinLength(10)]
        [RegularExpression(@"^([0-9]{10})$", ErrorMessage = "Invalid Mobile Number.")]
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }

        [DisplayName("Please enter name of dish")]
        [Required]
        [MinLength(3)]
        public string DishName { get => dishName; set => dishName = value; }

        [DisplayName("Enter description of dish")]
        [Required]
        [MinLength(7)]
        public string DishDescription { get => dishDescription; set => dishDescription = value; }

        [DisplayName("Do you have dietary restrictions? Gluten Free/Vegan/Allergies, etc.")]
        [Required]
        public bool Selection { get => selection; set => selection = value; }
    }
}
