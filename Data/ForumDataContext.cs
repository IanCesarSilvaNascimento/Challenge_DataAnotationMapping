using Forum.Models;
using Microsoft.EntityFrameworkCore;

namespace Forum.Data
{

    public class ForumDataContext : DbContext
    {

        public DbSet<Category>? Categories { get; set; }


        public DbSet<Post>? Posts { get; set; }


        public DbSet<Role>? Roles { get; set; }


        public DbSet<User>? Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            =>options.UseSqlServer("Server=localhost,1433;Database=Forum;User ID=sa;Password=1q2w3e4r@#$");


    }
}