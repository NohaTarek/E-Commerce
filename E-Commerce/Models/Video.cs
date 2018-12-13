using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce.Models
{
    public class Video
    {
        public int VideoId { get; set; }

        [Required(ErrorMessage = "You Must Enter Title")]
        public string Title { get; set; }

        public DateTime Duration { get; set; }

        [Required(ErrorMessage = "You Must Enter Course")]
        [Display(Name = "Course")]
        public int CourseId { get; set; }

        public Course course { get; set; }

        public ICollection<UserVideo> users { get; set; }
    }
}
