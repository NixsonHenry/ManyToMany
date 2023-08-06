using ManyToMany.Models;
using Microsoft.EntityFrameworkCore;

namespace ManyToMany.Data
{
    public class ManyToManyDbContext : DbContext
    {
        public ManyToManyDbContext(DbContextOptions<ManyToManyDbContext> options)
           : base(options)
        {

        }

        public DbSet<Post> Posts { get; set; }
        public DbSet<Tag> Tags { get; set; }


    }
}
