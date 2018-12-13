using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce.Models
{
    public class UserVideo
    {
        public int UserId { get; set; }

        public User user { get; set; }

        public int VideoId { get; set; }

        public Video video { get; set; }
    }
}
