using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce.Models
{
    public class User
    {
        public int UserId { get; set; }

        [Required(ErrorMessage = "You Must Enter Your Full Name")]
        [Display(Name = "Full Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "You Must Enter Username")]
        public string Username { get; set; }

        [Required(ErrorMessage = "You Must Enter Password")]
        [MinLength(8), MaxLength(15)]
        public string Password { get; set; }

        [Display(Name = "Phone Number")]
        public string Phone_No { get; set; }

        [Required(ErrorMessage = "You Must Enter Credit Card Number")]
        [Display(Name = "Credit Card Number")]
        public string Card_No { get; set; }

        [Required(ErrorMessage = "You Must Enter Expiration Date")]
        [Display(Name = "Expiration Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{dd-mm-yyyy}" ,ApplyFormatInEditMode = true)]
        public DateTime ExpirationDate { get; set; }

        public ICollection<UserVideo> videos { get; set; }

        public ICollection<UserCourse> courses { get; set; }
    }
}
