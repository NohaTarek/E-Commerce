using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce.Models
{
    public class Course
    {
        public int CourseId { get; set; }

        [Required(ErrorMessage = "You Must Enter Name")]
        [Display(Name = "Name")]
        public string CourseName { get; set; }

        [Required(ErrorMessage = "You Must Enter Description")]
        [Display(Name = "Description")]
        public string Description { get; set; }

        [Required(ErrorMessage = "You Must Enter Price")]
        [Display(Name = "Price")]
        [Column(TypeName = "decimal(10,2)")]
        public decimal Price { get; set; }

        public ICollection<Video> videos { get; set; }

        public ICollection<UserCourse> users { get; set; }
    }
}
