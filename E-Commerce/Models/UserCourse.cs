using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce.Models
{
    public class UserCourse
    {
        public int UserId { get; set; }

        public User _User { get; set; }

        public int CourseId { get; set; }

        public Course course { get; set; }
    }
}
