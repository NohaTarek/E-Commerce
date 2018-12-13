using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce.Data
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions<MyContext> options)
         : base(options)
        {
        }

        public DbSet<Models.Course> Courses { get; set; }
        public DbSet<Models.User> Users { get; set; }
        public DbSet<Models.UserCourse> UserCourses { get; set; }
        public DbSet<Models.UserVideo> UserVideos { get; set; }
        public DbSet<Models.Video> Videos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Models.UserCourse>()
                .HasKey(m => new { m.UserId, m.CourseId });

            modelBuilder.Entity<Models.UserCourse>()
                .HasOne(m => m._User)
                .WithMany(b => b.courses)
                .HasForeignKey(en => en.UserId);

            modelBuilder.Entity<Models.UserCourse>()
                .HasOne(m => m.course)
                .WithMany(c => c.users)
                .HasForeignKey(en => en.CourseId);


            modelBuilder.Entity<Models.UserVideo>()
              .HasKey(m => new { m.UserId, m.VideoId });

            modelBuilder.Entity<Models.UserVideo>()
                .HasOne(m => m.user)
                .WithMany(b => b.videos)
                .HasForeignKey(en => en.UserId);

            modelBuilder.Entity<Models.UserVideo>()
                .HasOne(m => m.video)
                .WithMany(c => c.users)
                .HasForeignKey(en => en.VideoId);
        }
    }
}
